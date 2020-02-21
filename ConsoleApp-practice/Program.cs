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
        }
    }
}
