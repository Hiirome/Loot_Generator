using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Generator.DBClasses
{
    class Atribute
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private bool IsPrefix { get; set; }
        private bool IsWpnValid { get; set; }
        private bool IsArmValid { get; set; }
        private bool IsAccValid { get; set; }
        private float OffBonus { get; set; }
        private float DefBonus { get; set; }
        private float SpeedBonus { get; set; }
        private int EffectChance { get; set; }
        private int Score { get; set; }
        private int Weight { get; set; }
    }
}
