using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Loot_Generator.DBClasses
{
    class Rarity
    {
        [Key] internal int Id { get; set; }
        internal string Name { get; set; }
        internal int ScoreMin { get; set; }
        internal int ScoreMax { get; set; }
        internal string Color { get; set; }
    }
}
