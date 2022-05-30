namespace SystemTask.Data.Models
{
    public class TehnicalSystem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SystemId { get; set; }

        public System System { get; set; }

        public int TehnicalId { get; set; }

        public Tehnical Tehnical { get; set; }

        public string Code { get; set; }
    }
}
