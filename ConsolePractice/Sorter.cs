using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsolePractice
{
    public class Sorter
    {
        public static void SortProducts(List<Product> products)
        {
            Console.WriteLine("ソート方法を選んでください(name/stock)");
            string sortMethod = Console.ReadLine() ?? "";

            List<Product> sortedProducts;

            if (sortMethod == "name")
            {
                sortedProducts = products.OrderBy(p => p.Name).ToList();
            }
            else if (sortMethod == "stock")
            {
                sortedProducts = products.OrderBy(p => p.Stock).ToList();
            }
            else
            {
                sortedProducts = products;
            }

            foreach (var p in sortedProducts)
            {
                Console.WriteLine($"{p.Name} : {p.Stock}");
            }
        }
    }
}