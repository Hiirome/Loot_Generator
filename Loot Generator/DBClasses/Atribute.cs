using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Generator.DBClasses
{
    class Atribute
    {
        [Key] internal int Id { get; set; }
        internal string Name { get; set; }
        internal bool IsPrefix { get; set; }
        internal bool IsWpnValid { get; set; }
        internal bool IsArmValid { get; set; }
        internal bool IsAccValid { get; set; }
        internal float OffBonus { get; set; }
        internal float DefBonus { get; set; }
        internal float SpeedBonus { get; set; }
        internal int EffectChance { get; set; }
        internal int Score { get; set; }
        internal int Weight { get; set; }
    }
}
