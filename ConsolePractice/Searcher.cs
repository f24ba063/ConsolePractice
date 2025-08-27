using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsolePractice
{
    public class Searcher
    {
        public static void SearchProducts(List<Product> products)
        {
            Console.WriteLine("検索方法を選択(name/range/both) :");
            string method = Console.ReadLine()?.ToLower();
            List<Product> results = new List<Product>();

            if (method == "name")
            {
                Console.WriteLine("検索する文字列を入力");
                string query = Console.ReadLine();
                results = products.Where(p => p.Name.Contains(query)).ToList();
            }
            else if (method == "range")
            {
                Console.WriteLine("在庫範囲を入力(最小,最大)：");
                var input = Console.ReadLine().Split(',');
                if (input.Length == 2 &&
                    int.TryParse(input[0], out int min) &&
                    int.TryParse(input[1], out int max))
                {
                    results = products.Where(p => p.Stock >= min && p.Stock <= max).ToList();
                }
                else { Console.WriteLine("入力が不正です"); return; }
            }
            else if (method == "both")
            {
                Console.WriteLine("検索する文字列を入力");
                string query = Console.ReadLine();
                Console.WriteLine("在庫範囲を入力(最小,最大)：");
                var input = Console.ReadLine().Split(',');
                if (input.Length == 2 &&
                    int.TryParse(input[0], out int min) &&
                    int.TryParse(input[1], out int max))
                {
                    results = products.Where(p => p.Name.Contains(query) && p.Stock >= min && p.Stock <= max).ToList();
                }
                else { Console.WriteLine("入力が不正です"); return; }
            }

            if (results.Count == 0)
            {
                Console.WriteLine("該当する商品はありません");
                return;
            }

            Console.WriteLine("検索結果：");
            foreach (var p in results)
                Console.WriteLine($"{p.Name}: {p.Stock}");
        }
    }
}