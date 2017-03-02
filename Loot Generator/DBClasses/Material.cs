using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Generator.DBClasses
{
    class Material
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private bool IsWpnValid { get; set; }
        private bool IsArmValid { get; set; }
        private bool IsAccValid { get; set; }
        private float OffMultiplier { get; set; }
        private float DefMultiplier { get; set; }
        private float SpeedMultiplier { get; set; }
        private float ScoreMultiplier { get; set; }
        private int Weight { get; set; }
    }
}
