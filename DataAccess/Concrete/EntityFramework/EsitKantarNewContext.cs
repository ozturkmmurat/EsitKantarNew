using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace DataAccess.Concrete.EntityFramework
{
    public class EsitKantarNewContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=YAYIN01;Initial Catalog=NewEsitKantar;User ID=emre;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                optionsBuilder.UseSqlServer("Server=94.102.74.13;Database=NewEsitKantar;User ID=websa;Password=v2qySqsu7MkXL5D;Connect Timeout=30;MultiSubnetFailover=False;");
            }
            
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<FeaturesDetail> FeaturesDetails { get; set; }
        public DbSet<FeaturesProduct> FeaturesProducts { get; set; }
        public DbSet<GeneralDetail> GeneralDetails { get; set; }
        public DbSet<GeneralProduct> GeneralProducts { get; set; }
        public DbSet<OptionalDetail> OptionalDetails { get; set; }
        public DbSet<OptionalProduct> OptionalProducts { get; set; }
        public DbSet<FeaturesImg> FeaturesImgs { get; set; }
        public DbSet<OptionalImg> OptionalImgs { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}


