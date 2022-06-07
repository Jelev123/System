namespace SystemTask.Data.Models.ViewModel
{
    using global::System;
    using global::System.Collections.Generic;

    public class CreateTehnicalViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public IEnumerable<TehnicalBloksInputModel> TehnicalBlocks { get; set; }

        public IEnumerable<TehnicalSystemInputModel> TehnicalSystems { get; set; }

        public IEnumerable<TehnicalEmployeesInputModel> TehnicalEmployees{ get; set; }
    }
}
