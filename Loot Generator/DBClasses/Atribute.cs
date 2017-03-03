namespace Loot_Generator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Atribute")]
    public partial class Atribute
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        public decimal IsPrefix { get; set; }

        public decimal IsWpnValid { get; set; }

        public decimal IsArmValid { get; set; }

        public decimal IsAccValid { get; set; }

        [Column(TypeName = "real")]
        public double OffBonus { get; set; }

        [Column(TypeName = "real")]
        public double DefBonus { get; set; }

        [Column(TypeName = "real")]
        public double SpeedBonus { get; set; }

        public long EffectChance { get; set; }

        public long Score { get; set; }

        public long Weight { get; set; }
    }
}
