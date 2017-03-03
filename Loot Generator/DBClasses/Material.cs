using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Loot_Generator.DBClasses
{
    class Material
    {
        [Key] internal int Id { get; set; }
        internal string Name { get; set; }
        internal bool IsWpnValid { get; set; }
        internal bool IsArmValid { get; set; }
        internal bool IsAccValid { get; set; }
        internal float OffMultiplier { get; set; }
        internal float DefMultiplier { get; set; }
        internal float SpeedMultiplier { get; set; }
        internal float ScoreMultiplier { get; set; }
        internal int Weight { get; set; }
    }
}
