namespace SystemTask.Data.Models.ViewModel
{
    using global::System;
    using global::System.Collections.Generic;

    public class CreateTehnicalViewModel
    {
        public string Name { get; set; }

        public string SystemName { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }

        public string BlockName { get; set; }

        public string BlockCode { get; set; }

        public int BlockId { get; set; }

        public DateTime CreationDate { get; set; }

        public string Activity { get; set; }

        public int PinNumber { get; set; }

        public IEnumerable<TehnicalBloksInputModel> TehnicalBlocks { get; set; }

        public IEnumerable<TehnicalSystemInputModel> TehnicalSystems { get; set; }

        public IEnumerable<TehnicalEmployeesInputModel> TehnicalEmployees{ get; set; }
    }
}
