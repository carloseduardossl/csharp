using System;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Level test = Level.high;
            switch (test)
            {
                case Level.medium:
                    Console.WriteLine("Nivel Medio!");
                    break;
                case Level.high:
                    Console.WriteLine("Nivel Alto");
                    break;
                case Level.low:
                    Console.WriteLine("Level Baixo");
                    break;
            }
        }
    }
}