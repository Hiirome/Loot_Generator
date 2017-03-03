namespace Loot_Generator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeaponType")]
    public partial class WeaponType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        [Column(TypeName = "real")]
        public double BaseDamage { get; set; }

        [Column(TypeName = "real")]
        public double BaseDefense { get; set; }

        [Column(TypeName = "real")]
        public double BaseAttackSpeed { get; set; }

        public long Score { get; set; }
    }
}
