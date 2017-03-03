namespace Loot_Generator
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LootGeneratorDB : DbContext
    {
        public LootGeneratorDB()
            : base("name=LootGeneratorDB")
        {
        }

        public virtual DbSet<AccessoryType> AccessoryType { get; set; }
        public virtual DbSet<ArmorType> ArmorType { get; set; }
        public virtual DbSet<Atribute> Atribute { get; set; }
        public virtual DbSet<Gemstone> Gemstone { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Rarity> Rarity { get; set; }
        public virtual DbSet<StatsAccessory> StatsAccessory { get; set; }
        public virtual DbSet<WeaponType> WeaponType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessoryType>()
                .Property(e => e.IsGemmable)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Atribute>()
                .Property(e => e.IsPrefix)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Atribute>()
                .Property(e => e.IsWpnValid)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Atribute>()
                .Property(e => e.IsArmValid)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Atribute>()
                .Property(e => e.IsAccValid)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Material>()
                .Property(e => e.IsWpnValid)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Material>()
                .Property(e => e.IsArmValid)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Material>()
                .Property(e => e.IsAccValid)
                .HasPrecision(53, 0);

            modelBuilder.Entity<StatsAccessory>()
                .Property(e => e.IsPersentile)
                .HasPrecision(53, 0);
        }
    }
}
