using System;
using System.Collections.Generic;

namespace ConsolePractice
{
    public class Deleter
    {
        public static void DeleteProduct(List<Product> products)
        {
            Console.Write("削除する商品の名前：");
            string delName = Console.ReadLine();
            Product delTarget = products.Find(p => p.Name == delName);
            if (delTarget != null)
            {
                products.Remove(delTarget);
                Console.WriteLine($"{delName}を削除しました");
            }
            else
            {
                Console.WriteLine("商品が見つかりません");
            }
        }
    }
}