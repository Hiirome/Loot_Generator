namespace Loot_Generator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rarity")]
    public partial class Rarity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        public long ScoreMin { get; set; }

        public long ScoreMax { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Color { get; set; }
    }
}
