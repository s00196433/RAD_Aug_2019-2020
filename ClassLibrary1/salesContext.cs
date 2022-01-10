using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.salesModels;

namespace ClassLibrary1
{
    public class salesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public salesContext()
            : base("SalesConnection")
        {
        }
        public static salesContext Create()
        {
            return new salesContext();
        }
    }
}
