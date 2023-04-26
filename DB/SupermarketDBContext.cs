using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AppDBContext context = new();
//context.Database.Migrate();
namespace OnlineShopping.DB
{
    public class SupermarketDBContext : DbContext
    {
        public static SupermarketDBContext context = new SupermarketDBContext();
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost; Port=3333; Database=supermarket3DB; UId=root; Pwd=root");
        }
        

    }
}
