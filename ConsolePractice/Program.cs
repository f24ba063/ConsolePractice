using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsolePractice
{
    public class Product
    {
        public string Name { get; private set; }
        public int Stock { get; private set; }

        public Product(string name, int stock)
        {
            Name = name;
            Stock = stock;
        }

        public void AddStock(int amount)
        {
            if (amount > 0)
            {
                Stock += amount;
                Console.WriteLine($"{amount}個の在庫が加算されました");
                HistoryLogger.Log(Name, "add", amount, Stock);
            }
            else
            {
                Console.WriteLine("正の数を入力してください");
            }
        }

        public bool RemoveStock(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("正の数を入力してください");
                return false;
            }

            if (Stock < amount)
            {
                Console.WriteLine("在庫不足です。再入力してください");
                return false;
            }

            Stock -= amount;
            Console.WriteLine($"{amount}個の在庫が出庫されました");
            HistoryLogger.Log(Name, "remove", amount, Stock);
            return true;
        }
    }

    class Program
    {
        static string filePath = "products.txt";

        static void Main(string[] args)
        {
            List<Product> products = ProductFiler.LoadProducts(filePath);
            Console.WriteLine("カレントディレクトリ: " + Directory.GetCurrentDirectory());

            while (true)
            {
                Console.WriteLine("\n在庫一覧:");
                foreach (var p in products)
                    Console.WriteLine($"{p.Name}:{p.Stock}");

                Console.WriteLine("\n操作を入力してください(add/remove/sort/search/delete/new/history/exit)");
                string command = Console.ReadLine()?.ToLower();

                if (command == "exit")
                {
                    ProductFiler.SaveProducts(products, filePath);
                    break;
                }

                if (command == "new")
                {
                    Updater.UpdateProducts(products);
                    continue;
                }

                if (command == "delete")
                {
                    Deleter.DeleteProduct(products);
                    continue;
                }

                if (command == "sort")
                {
                    Sorter.SortProducts(products);
                    continue;
                }

                if (command == "search")
                {
                    Searcher.SearchProducts(products);
                    continue;
                }

                if (command == "history")
                {
                    HistoryLogger.ShowHistory();
                    continue;
                }

                // add/remove 操作
                Console.Write("商品名を入力：");
                string name = Console.ReadLine();
                Product target = products.Find(p => p.Name == name);

                if (target == null)
                {
                    Console.WriteLine("商品がみつかりません");
                    continue;
                }

                if (command == "add")
                {
                    int amount;
                    while (true)
                    {
                        Console.WriteLine("数量を入力：");
                        if (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                        {
                            Console.WriteLine("正の整数を入力してください");
                            continue;
                        }
                        break;
                    }
                    target.AddStock(amount);
                }
                else if (command == "remove")
                {
                    int amount;
                    bool success = false;
                    while (!success)
                    {
                        Console.WriteLine("数量を入力：");
                        if (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                        {
                            Console.WriteLine("正の整数を入力してください");
                            continue;
                        }
                        success = target.RemoveStock(amount);
                    }
                }
                else
                {
                    Console.WriteLine("不明なコマンドです");
                }
            }
        }
    }
}