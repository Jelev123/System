namespace SystemTask.Data.Models
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;

    public class System
    {
        public int Id { get; set; }

        [StringLength(100)]

        public string Name { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

    }
}
