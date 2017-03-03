using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;

namespace Loot_Generator.DBClasses
{
    class LootGeneratorContext : DbContext
    {

        public LootGeneratorContext() : base(ConnectionString("LootGeneratorDB")) { }

        private static string ConnectionString(string connKey)
        {
            var conn = ConfigurationManager.ConnectionStrings[connKey].ConnectionString;
            return conn;
        }

        public DbSet<AccessoryType> AccessoryTypes { get; set; }
        public DbSet<ArmorType> ArmorTypes { get; set; }
        public DbSet<Atribute> Atributes { get; set; }
        public DbSet<Gemstone> Gemstones { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Rarity> Rarities { get; set; }
        public DbSet<StatsAccessory> StatsAccessories { get; set; }
        public DbSet<WeaponType> WeaponTypes { get; set; }
    }
}
