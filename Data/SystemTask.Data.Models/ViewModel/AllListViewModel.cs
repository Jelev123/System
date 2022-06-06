namespace SystemTask.Data.Models.ViewModel
{
    using global::System.Collections.Generic;

    public class AllListViewModel
    {
        public virtual IEnumerable<AllViewModel> Tehnicals { get; set; }

        public virtual IEnumerable<TehnicalBloksInputModel> TehnicalBlocks { get; set; }

        public IEnumerable<TehnicalEmployeesInputModel> TehnicalEmployees { get; set; }

        public IEnumerable<TehnicalSystemInputModel> TehnicalSystems { get; set; }
    }
}
