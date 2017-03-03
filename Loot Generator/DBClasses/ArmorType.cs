using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Generator.DBClasses
{
    class ArmorType
    {
        [Key] internal int Id { get; set; }
        internal string Name { get; set; }
        internal float BaseDamage { get; set; }
        internal float BaseDefense { get; set; }
        internal int Score { get; set; }
    }
}
