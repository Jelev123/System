namespace SystemTask.Data.Models
{
    public class TehnicalEmployee
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int TehnicalId { get; set; }

        public Tehnical Tehnical { get; set; }

        public int PinNumber { get; set; }
    }
}
