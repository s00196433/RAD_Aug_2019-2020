namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using ClassLibrary1.salesModels;

    internal sealed class Configuration : DbMigrationsConfiguration<ClassLibrary1.salesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClassLibrary1.salesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            context.Customers.AddOrUpdate(customer => customer.ID, new Customer[] {
               new Customer
               {
                   ID= 1,
                   Name="Customer 1",
                   Address="Address for Customer 1"
               },
                new Customer
               {
                   ID= 2,
                   Name="Customer 2",
                   Address="Address for Customer 2"
               },
                new Customer
               {
                   ID= 3,
                   Name="Customer 3",
                   Address="Address for Customer 3"
               },
              
            });

            context.SalesOrders.AddOrUpdate(salesOrder => salesOrder.ID, new SalesOrder[] {
               new SalesOrder
               {
                   ID = 1,
                   CustomerID=1,
                   orderDate= DateTime.Parse("12/01/2002")
               },
              new SalesOrder
               {
                   ID = 2,
                   CustomerID=2,
                   orderDate= DateTime.Parse("31/10/2004")
               },
               new SalesOrder
               {
                   ID = 3,
                   CustomerID=2,
                   orderDate= DateTime.Parse("10/10/2014")
               },

            });
            context.OrderLines.AddOrUpdate(orderLine => orderLine.ID, new OrderLine[] {
               new OrderLine
               {
                   ID=1,
                   SalesOrderID=1,
                   ProductID=1,
                   QtyOrder=10
               },
               new OrderLine
               {
                   ID=2,
                   SalesOrderID=1,
                   ProductID=2,
                   QtyOrder=12
               },
              new OrderLine
               {
                   ID=3,
                   SalesOrderID=2,
                   ProductID=1,
                   QtyOrder=3
               },
               new OrderLine
               {
                   ID=4,
                   SalesOrderID=2,
                   ProductID=2,
                   QtyOrder=4
               },
              new OrderLine
               {
                   ID=5,
                   SalesOrderID=2,
                   ProductID=3,
                   QtyOrder=5
               },
              new OrderLine
               {
                   ID=6,
                   SalesOrderID=3,
                   ProductID=2,
                   QtyOrder=2
               },
              new OrderLine
               {
                   ID=7,
                   SalesOrderID=3,
                   ProductID=3,
                   QtyOrder=2
               },
            });
            context.Products.AddOrUpdate(product => product.ID, new Product[] {
               new Product
               {
                   ID = 1,
                   Description="Item 1",
                   FirstStock= DateTime.Parse("1/01/2002"),
                   UnitCost=200,
                   QuantityInStock=12,
                   ReOrderQuantity=10
               },
              new Product
               {
                   ID = 2,
                   Description="Item 2",
                   FirstStock= DateTime.Parse("30/11/2003"),
                   UnitCost=100,
                   QuantityInStock=1,
                   ReOrderQuantity=15
               },
              new Product
               {
                   ID = 3,
                   Description="Item 3",
                   FirstStock= DateTime.Parse("10/10/2000"),
                   UnitCost=300,
                   QuantityInStock=3,
                   ReOrderQuantity=2
               },
            });
        }
    }
}
