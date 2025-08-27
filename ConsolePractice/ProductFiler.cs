using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsolePractice
{
    public class ProductFiler
    {
        public static void SaveProducts(List<Product> products, string filePath)
        {
            List<string> lines = products.Select(p => $"{p.Name}, {p.Stock}").ToList();
            File.WriteAllLines(filePath, lines);
        }

        public static List<Product> LoadProducts(string filePath)
        {
            var products = new List<Product>();
            if (!File.Exists(filePath)) return products;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(',');
                if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int stock))
                    products.Add(new Product(parts[0].Trim(), stock));
            }

            return products;
        }
    }
}