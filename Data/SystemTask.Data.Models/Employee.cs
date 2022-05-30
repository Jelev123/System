namespace SystemTask.Data.Models
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;

    public class Employee
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]

        public string SurName { get; set; }

        [StringLength(100)]

        public string LastName { get; set; }

        public string Activity { get; set; }

        public int PinNumber { get; set; }

        

    }
}
