using System;
using System.IO;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            Console.WriteLine(input);
        }
    }
}