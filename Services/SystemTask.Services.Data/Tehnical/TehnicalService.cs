namespace SystemTask.Services.Data.Tehnical
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SystemTask.Data.Common.Repositories;
    using SystemTask.Data.Models;
    using SystemTask.Data.Models.ViewModel;

    public class TehnicalService : ITehnicalService
    {
        private readonly IRepository<Tehnical> tehnicalRepository;
        private readonly IRepository<Block> blockRepository;
        private readonly IRepository<System> systemRepository;
        private readonly IRepository<Employee> employeeRepository;

        public TehnicalService(IRepository<Tehnical> tehnicalRepository, IRepository<Block> blockRepository, IRepository<System> systemRepository, IRepository<Employee> employeeRepository)
        {
            this.tehnicalRepository = tehnicalRepository;
            this.blockRepository = blockRepository;
            this.systemRepository = systemRepository;
            this.employeeRepository = employeeRepository;
        }

        public async Task Create(CreateTehnicalViewModel create)
        {
            Tehnical tehnical = new Tehnical()
            {
                Name = create.Name,
                Description = create.Description,
                DateAndTimeCreated = create.CreationDate,
            };

            foreach (var blocks in create.TehnicalBlocks)
            {
                var block = this.blockRepository.All().FirstOrDefault(x => x.Name == blocks.BlockName);

                if (block == null)
                {
                    block = new Block { Name = blocks.BlockName };
                }

                tehnical.TehnicalBlocks.Add(new TehnicalBlock
                {
                    Block = block,
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
                        FirstName = employees.FirstName,
                        SurName = employees.SurName,
                        LastName = employees.LastName,
                        Activity = employees.Activity,
                    };
                }

                tehnical.TehnicalEmployees.Add(new TehnicalEmployee
                {
                    Employee = employee,
                    PinNumber = employees.PinNumber,
                });
            }

            await this.tehnicalRepository.AddAsync(tehnical);
            await this.tehnicalRepository.SaveChangesAsync();
        }

        public IEnumerable<AllViewModel> GetAll<T>(int id)
        {

            var all = this.tehnicalRepository.All()
                 .Select(s => new AllViewModel
                 {
                     Name = s.Name,
                     Description = s.Description,

                 });
            return all;
        }
    }
}
