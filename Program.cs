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
        }
        }
    }

