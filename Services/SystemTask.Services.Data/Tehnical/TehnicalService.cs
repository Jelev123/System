namespace SystemTask.Services.Data.Tehnical
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using SystemTask.Data.Common.Repositories;
    using SystemTask.Data.Models;
    using SystemTask.Data.Models.ViewModel;

    public class TehnicalService : ITehnicalService
    {
        private readonly IRepository<Tehnical> tehnicalRepository;
        private readonly IRepository<Block> blockRepository;
        private readonly IRepository<System> systemRepository;
        private readonly IRepository<Employee> employeeRepository;
        private readonly IRepository<TehnicalBlock> tehBlocksRepository;
        private readonly IRepository<TehnicalEmployee> tehEmoloyeeRepository;
        private readonly IRepository<TehnicalSystem> tehSystemRepository;
        private readonly IMapper mapper;

        public TehnicalService(IRepository<Tehnical> tehnicalRepository, IRepository<Block> blockRepository, IRepository<System> systemRepository, IRepository<Employee> employeeRepository,
            IMapper mapper, IRepository<TehnicalBlock> tehBlocksRepository, IRepository<TehnicalEmployee> tehEmoloyeeRepository, IRepository<TehnicalSystem> tehSystemRepository)
        {
            this.tehnicalRepository = tehnicalRepository;
            this.blockRepository = blockRepository;
            this.systemRepository = systemRepository;
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
            this.tehBlocksRepository = tehBlocksRepository;
            this.tehEmoloyeeRepository = tehEmoloyeeRepository;
            this.tehSystemRepository = tehSystemRepository;
        }

        public async Task Create(CreateTehnicalViewModel create)
        {
            Tehnical tehnical = new Tehnical()
            {
                Id = create.Id,
                Name = create.Name,
                Description = create.Description,
                DateAndTimeCreated = create.CreationDate,
            };

            foreach (var blocks in create.TehnicalBlocks)
            {
                var block = this.blockRepository.All().FirstOrDefault(x => x.Name == blocks.BlockName);

                if (block == null)
                {
                    block = new Block { Name = blocks.BlockName, Code = blocks.Code};
                }

                tehnical.TehnicalBlocks.Add(new TehnicalBlock
                {
                    Block = block,
                    Id = blocks.BlockId,
                    Name = blocks.BlockName,
                    Code = blocks.Code,
                });
            }

            foreach (var systems in create.TehnicalSystems)
            {
                var system = this.systemRepository.All().FirstOrDefault(s => s.Name == systems.SystemName);

                if (system == null)
                {
                    system = new System { Name = systems.SystemName };
                }

                tehnical.TehnicalSystems.Add(new TehnicalSystem
                {
                    Id = system.Id,
                    System = system,
                    Code = systems.Code,
                    Name = system.Name,
                });
            }

            foreach (var employees in create.TehnicalEmployees)
            {
                var employee = this.employeeRepository.All().FirstOrDefault(s => s.FirstName == employees.FirstName);

                if (employee == null)
                {
                    employee = new Employee
                    {
                        Id = employee.Id,
                        FirstName = employees.FirstName,
                        SurName = employees.SurName,
                        LastName = employees.LastName,
                        Activity = employees.Activity,
                    };
                }

                tehnical.TehnicalEmployees.Add(new TehnicalEmployee
                {
                    Employee = employee,
                    Id = employee.Id,
                    PinNumber = employees.PinNumber,
                    FirstName = employees.FirstName,
                    SurName = employees.SurName,
                    LastName = employees.LastName,
                });
            }

            await this.tehnicalRepository.AddAsync(tehnical);
            await this.tehnicalRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAllBlocks<T>(int id)
        {
            var all = this.tehBlocksRepository.All()
                 .ProjectTo<T>(this.mapper.ConfigurationProvider);
            return all;
        }

        public IEnumerable<T> GetAllEmployees<T>(int id)
        {
            var all = this.tehEmoloyeeRepository.All()
               .ProjectTo<T>(this.mapper.ConfigurationProvider);
            return all;
        }

        public IEnumerable<T> GetAllSystems<T>(int id)
        {
            var all = this.tehSystemRepository.All()
               .ProjectTo<T>(this.mapper.ConfigurationProvider);
            return all;
        }

        public IEnumerable<T> GetAllTehnical<T>(int id)
        {

            var all = this.tehnicalRepository.All()
                 .ProjectTo<T>(this.mapper.ConfigurationProvider);
            return all;
        }
    }
}
