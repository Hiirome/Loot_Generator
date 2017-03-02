using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Generator.DBClasses
{
    class WeaponType
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private float BaseDamage { get; set; }
        private float BaseDefense { get; set; }
        private float BaseAttackSpeed { get; set; }
        private int Score { get; set; }
    }
}
