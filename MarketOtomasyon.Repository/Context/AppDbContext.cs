using MarketOtomasyon.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Repository.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = 202-00;Database = MarketOtomasyonDb;User Id=sa;Password=1234;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
