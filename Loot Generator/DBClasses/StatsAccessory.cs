using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Generator.DBClasses
{
    class StatsAccessory
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private bool IsPercentile { get; set; }
        private int ScoreBonus { get; set; }
    }
}
