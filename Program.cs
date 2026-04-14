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
        }
        }
    }

