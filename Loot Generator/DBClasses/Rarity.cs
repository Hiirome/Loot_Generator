using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Generator.DBClasses
{
    class Rarity
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private int ScoreMin { get; set; }
        private int ScoreMax { get; set; }
        private string Color { get; set; }
    }
}
