using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Loot_Generator.DBClasses
{
    class Gemstone
    {
        [Key] internal int Id { get; set; }
        internal string Name { get; set; }
    }
}
