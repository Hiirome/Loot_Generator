using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Loot_Generator.DBClasses
{
    class WeaponType
    {
        [Key] internal int Id { get; set; }
        internal string Name { get; set; }
        internal float BaseDamage { get; set; }
        internal float BaseDefense { get; set; }
        internal float BaseAttackSpeed { get; set; }
        internal int Score { get; set; }
    }
}
