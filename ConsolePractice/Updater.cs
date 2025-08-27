using System;
using System.Collections.Generic;

namespace ConsolePractice
{
    public class Updater
    {
        public static void UpdateProducts(List<Product> products)
        {
            Console.Write("新しい商品の名前：");
            string newName = Console.ReadLine();
            Console.Write("初期在庫数：");
            if (int.TryParse(Console.ReadLine(), out int newStock))
            {
                products.Add(new Product(newName, newStock));
                Console.WriteLine("商品を追加しました");
            }
            else
            {
                Console.WriteLine("数値を入力してください");
            }
        }
    }
}