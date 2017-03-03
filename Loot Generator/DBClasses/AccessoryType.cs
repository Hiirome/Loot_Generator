using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Generator.DBClasses
{
    class AccessoryType
    {

        
        [Key] internal int Id { get; set; }
        internal string Name { get; set; }
        internal float StatBase1 { get; set; }
        internal float StatBase2 { get; set; }
        internal float StatBase3 { get; set; }
        internal bool IsGemmable { get; set; }
        internal int Score { get; set; }
    }
}
