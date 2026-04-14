using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProductList = new List<Product>
            {
                new Product { ProductName = "Chai", Category = "Beverages", UnitPrice = 18, UnitsInStock = 39 },
                new Product { ProductName = "Chang", Category = "Beverages", UnitPrice = 19, UnitsInStock = 17 },
                new Product { ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10, UnitsInStock = 13 },
                new Product { ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22, UnitsInStock = 53 },
                new Product { ProductName = "Ikura", Category = "Seafood", UnitPrice = 31, UnitsInStock = 20 },
                new Product { ProductName = "Konbu", Category = "Seafood", UnitPrice = 6, UnitsInStock = 24 }
            };
            List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                CustomerID = "ALFKI",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1, OrderDate = new DateTime(1996, 7, 4) },
                    new Order { OrderID = 2, OrderDate = new DateTime(1998, 1, 15) }
                }
            },
            new Customer
            {
                CustomerID = "ANATR",
                Orders = new List<Order>
                {
                    new Order { OrderID = 3, OrderDate = new DateTime(1997, 3, 10) },
                    new Order { OrderID = 4 ,OrderDate = new DateTime(1999, 5, 6) }
                }
            },
            new Customer
            {
                CustomerID = "ANTON",
                Orders = new List<Order>
                {
                    new Order { OrderID = 5, OrderDate = new DateTime(1995, 12, 1) },
                    new Order { OrderID = 6, OrderDate = new DateTime(2000, 6, 20) }
                }
            }
        };

            #region Q1

            //    var seafoodProducts = ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .Select(p => new { p.ProductName, p.UnitPrice });

            //    foreach (var p in seafoodProducts)
            //    {
            //        Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //    } 
            #endregion

            #region Q2
            //var productNames = ProductList.Select(p => p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name); 
            #endregion

            #region Q3
            //var sortedByPrice = ProductList
            //.OrderBy(p => p.UnitPrice)
            //.Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var p in sortedByPrice)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //} 
            #endregion

            #region Q4
            //var midRangeProducts = ProductList
            // .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var p in midRangeProducts)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //} 
            #endregion

            #region Q5
            //var condimentsInStock = ProductList
            // .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var p in condimentsInStock)
            //{
            //    Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
            //} 
            #endregion

            #region Q6
            //var productStatus = ProductList
            //.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var p in productStatus)
            //{
            //    Console.WriteLine($"{p.Name} - {p.Price} - {p.StockStatus}");
            //} 
            #endregion

            #region Q7
            //var indexedProducts = ProductList
            //.Select((p, index) => new { Index = index + 1, p.ProductName });

            //foreach (var p in indexedProducts)
            //{
            //    Console.WriteLine($"{p.Index}. {p.ProductName}");
            //} 
            #endregion

            #region Q8
            //var sortedProducts = ProductList
            //.OrderBy(p => p.Category)
            //.ThenByDescending(p => p.UnitPrice);

            //foreach (var p in sortedProducts)
            //{
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //} 
            #endregion

            #region Q9
            //var beverages = ProductList
            //.Where(p => p.Category == "Beverages")
            //.OrderByDescending(p => p.UnitsInStock)
            //.Select(p => new { p.ProductName, p.UnitsInStock });

            //foreach (var p in beverages)
            //{
            //    Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
            //} 
            #endregion

            #region Q10
            //var orders1997 =
            //from c in Customers
            //from o in c.Orders
            //where o.OrderDate.Year >= 1997
            //select new
            //{
            //    c.CustomerID,
            //    o.OrderDate
            //};

            //foreach (var o in orders1997)
            //{
            //    Console.WriteLine($"{o.CustomerID} - {o.OrderDate}");
            //} 
            #endregion

            #region Q11
            //var productWithIndex = ProductList
            //.Select((p, index) => new { Position = index + 1, p.ProductName });

            //foreach (var p in productWithIndex)
            //{
            //    Console.WriteLine($"{p.Position} - {p.ProductName}");
            //} 
            #endregion
        }
        }
    }

