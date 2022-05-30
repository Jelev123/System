namespace SystemTask.Services.Data.Block
{
    using System.Collections.Generic;

    public interface IBlockService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();

    }
}
