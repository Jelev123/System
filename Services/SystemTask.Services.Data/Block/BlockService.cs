namespace SystemTask.Services.Data.Block
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SystemTask.Data.Common.Repositories;
    using SystemTask.Data.Models;

    public class BlockService : IBlockService
    {
        private readonly IRepository<Block> blockRepository;

        public BlockService(IRepository<Block> blockRepository)
        {
            this.blockRepository = blockRepository;
        }
        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.blockRepository.AllAsNoTracking()
               .Select(s => new
               {
                   s.Id,
                   s.Name,
               })
               .OrderBy(s => s.Name)
               .ToList().Select(s => new KeyValuePair<string, string>(s.Id.ToString(), s.Name));
        }
    }
}
