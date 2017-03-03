namespace Loot_Generator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        public decimal IsWpnValid { get; set; }

        public decimal IsArmValid { get; set; }

        public decimal IsAccValid { get; set; }

        [Column(TypeName = "real")]
        public double OffMultiplier { get; set; }

        [Column(TypeName = "real")]
        public double DefMultiplier { get; set; }

        [Column(TypeName = "real")]
        public double SpeedMultiplier { get; set; }

        [Column(TypeName = "real")]
        public double ScoreMultiplier { get; set; }

        public long Weight { get; set; }
    }
}
