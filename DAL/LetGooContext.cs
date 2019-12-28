using MODELS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LetGooContext:DbContext
    {
        public LetGooContext() : base("cstr")
        {

        }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Urun> Urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().ToTable("tblKullanicilar");
            modelBuilder.Entity<Kullanici>().Property(k => k.KullaniciAd).IsRequired().HasMaxLength(25).HasColumnType("varchar");
            modelBuilder.Entity<Kullanici>().Property(k => k.Sifre).IsRequired().HasMaxLength(25).HasColumnType("varchar");

            modelBuilder.Entity<Urun>().ToTable("tblUrunler");
            modelBuilder.Entity<Urun>().Property(u => u.UrunAd).IsRequired().HasMaxLength(35).HasColumnType("varchar");
            modelBuilder.Entity<Urun>().Property(u => u.KullaniciId).IsRequired().HasColumnName("KullaniciId");
            modelBuilder.Entity<Urun>().Property(u => u.Fiyat).IsRequired();
        }
    }
}
