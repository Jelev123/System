namespace SystemTask.Data.Models.ViewModel
{
    using global::System.Collections.Generic;

    public class AllListViewModel
    {
        public virtual IEnumerable<AllViewModel> Tehnicals { get; set; }
        public IEnumerable<TehnicalBlock> TehnicalBlocks { get; set; }

    }
}
