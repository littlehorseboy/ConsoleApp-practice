using System;

namespace ConsoleApp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請問你的名字？");
            string username = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine($"你好，{username}");

            int dayOfYear = DateTime.Now.DayOfYear;

            Console.Write("今天是一年中的第 ");
            Console.Write(dayOfYear);
            Console.Write(" 天");
        }
    }
}
