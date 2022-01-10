using System;

using System.Collections.Generic;
using System.Linq;
using ClassLibrary1;
using ClassLibrary1.salesModels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter Customer ID to see transactions (7,8,9)");
            int CustomerIDtransaction = Convert.ToInt32(Console.ReadLine());

            using (salesContext db = new salesContext())
            {
                DateTime baseData = DateTime.Parse("09/01/2022");
                Random r = new Random();

                //List<Customer> get_transactions = db.Customers.ToList();
                //Console.WriteLine("get_transactions");
                //foreach (var item in get_transactions)
                //{
                //    Console.WriteLine("{0}", item.Name);

                //}



                Console.WriteLine("get_Sales_orders");
                var get_Sales_orders = (from so in db.SalesOrders
                                        join ol in db.OrderLines
                                        on so.ID equals ol.SalesOrderID
                                        select new
                                        {
                                            soCustomerID = so.CustomerID,
                                            soID = so.ID,
                                            soOrderDate = so.orderDate,
                                            olID = ol.ID,
                                            productID = ol.ProductID,
                                            QtyOrder = ol.QtyOrder
                                            
                                        })
                              .OrderBy(order => order.soCustomerID);

                foreach (var item in get_Sales_orders)
                {
                    if (item.soCustomerID == CustomerIDtransaction)
                        Console.WriteLine("{0} ", String.Concat(item.soCustomerID, " ",item.soOrderDate," ", item.olID," ",item.soID," ",item.productID," ",item.QtyOrder));
                }
            
            }
            Console.ReadLine();
        }
    }
}
