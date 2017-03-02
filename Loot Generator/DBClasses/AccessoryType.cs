using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Generator.DBClasses
{
    class AccessoryType
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private float StatBase1 { get; set; }
        private float StatBase2 { get; set; }
        private float StatBase3 { get; set; }
        private bool IsGemmable { get; set; }
        private int Score { get; set; }
    }
}
