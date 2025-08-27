using System;
using System.IO;

namespace ConsolePractice
{
    public static class HistoryLogger
    {
        static string historyFile = "history.txt";

        public static void Log(string name, string action, int amount, int afterStock)
        {
            string line = $"{DateTime.Now:yyyy-MM-dd HH:mm}, {name}, {action}, {amount}, {afterStock}";
            File.AppendAllLines(historyFile, new string[] { line });
        }

        public static void ShowHistory()
        {
            if (!File.Exists(historyFile))
            {
                Console.WriteLine("履歴はありません");
                return;
            }

            var lines = File.ReadAllLines(historyFile);
            Console.WriteLine("==履歴==");
            foreach (var line in lines)
                Console.WriteLine(line);
            Console.WriteLine("==履歴ここまで==");
        }
    }
}