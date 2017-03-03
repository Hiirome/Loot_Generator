namespace Loot_Generator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessoryType")]
    public partial class AccessoryType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        [Column(TypeName = "real")]
        public double StatBase1 { get; set; }

        [Column(TypeName = "real")]
        public double StatBase2 { get; set; }

        [Column(TypeName = "real")]
        public double StatBase3 { get; set; }

        public decimal IsGemmable { get; set; }

        public long Score { get; set; }
    }
}
