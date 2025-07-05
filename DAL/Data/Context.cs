using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
   public class Context:DbContext
    {

        public DbSet<Product> products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Catigory> Cateigorys { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source =.\\SQLEXPRESS; Initial Catalog =Cafitiraa ; Integrated Security = True; Encrypt = True; Trust Server Certificate = True");

            //base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>(s =>
            {
                s.HasKey(c => new { c.OrderId, c.ProductId });

            });
            //base.OnModelCreating(modelBuilder);
        }

    }
}
