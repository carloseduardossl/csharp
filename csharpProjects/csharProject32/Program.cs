using System;

namespace myApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Celta", "Preto", 2004);
            Console.WriteLine($"{myCar.modelo} {myCar.cor} {myCar.ano}");
        }

    }
}