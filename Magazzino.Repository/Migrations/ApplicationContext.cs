using System;
using System.Collections.Generic;
using System.Text;
using Magazzino.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using System.Data;

namespace Magazzino.Repository.Migrations
{
    public class ApplicationContext : DbContext
    {
       public string conexion = (@"Server=DESKTOP-EKCFJTF\\SQLEXPRESS; Database=Magazzino; User Id=usr_intec;Password=12345678");
        private DbContextOptionsBuilder<ApplicationContext> optionsBuilder;

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet <Sales> SalesInPlurar { get; set; }
        public DbSet <Seller> Sellers { get; set; }
        public DbSet <Product> Products { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
            }
        }

        public string conexiondada()
        {
            return conexion;
        }
    }
}
