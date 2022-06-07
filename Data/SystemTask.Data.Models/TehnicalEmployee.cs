namespace SystemTask.Data.Models
{
    using global::System.ComponentModel.DataAnnotations.Schema;

    public class TehnicalEmployee
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int TehnicalId { get; set; }

        public Tehnical Tehnical { get; set; }

        public int PinNumber { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string LastName { get; set; }

        public string Activity { get; set; }


    }
}
