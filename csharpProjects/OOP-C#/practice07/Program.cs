using System;
using System.IO;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt"); // Advent Of Code 2023 Day 01 input
            Console.WriteLine(input);
        }
    }
}