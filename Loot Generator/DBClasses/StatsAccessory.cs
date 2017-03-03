using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Loot_Generator.DBClasses
{
    class StatsAccessory
    {
        [Key] internal int Id { get; set; }
        internal string Name { get; set; }
        internal bool IsPercentile { get; set; }
        internal int ScoreBonus { get; set; }
    }
}
