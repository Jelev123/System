namespace SystemTask.Data.Models
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;

    public class Tehnical
    {

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateAndTimeCreated { get; set; }

        public virtual ICollection<TehnicalBlock> TehnicalBlocks { get; set; } = new HashSet<TehnicalBlock>();

        public virtual ICollection<TehnicalSystem> TehnicalSystems { get; set; } = new HashSet<TehnicalSystem>();

        public virtual ICollection<TehnicalEmployee> TehnicalEmployees { get; set; } = new HashSet<TehnicalEmployee>();

    }
}
