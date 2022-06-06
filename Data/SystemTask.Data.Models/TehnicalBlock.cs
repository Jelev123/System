namespace SystemTask.Data.Models
{

    public class TehnicalBlock
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BlockId { get; set; }

        public Block Block { get; set; }

        public int TehnicalId { get; set; }

        public Tehnical Tehnical { get; set; }

        public string Code { get; set; }
    }
}
