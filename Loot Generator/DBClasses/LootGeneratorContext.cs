using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Loot_Generator.DBClasses
{
    class LootGeneratorContext : DbContext
    {
        private DbSet<AccessoryType> AccessoryTypes { get; set; }
        private DbSet<ArmorType> ArmorTypes { get; set; }
        private DbSet<Atribute> Atributes { get; set; }
        private DbSet<Gemstone> Gemstones { get; set; }
        private DbSet<Material> Materials { get; set; }
        private DbSet<Rarity> Rarities { get; set; }
        private DbSet<StatsAccessory> StatsAccessories { get; set; }
        private DbSet<WeaponType> WeaponTypes { get; set; }
    }
}
