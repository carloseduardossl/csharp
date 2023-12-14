using System;

namespace myAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ola = new Car();
            Console.WriteLine(ola.nome);

            Car novoCarro = new Car();
            novoCarro.nome = "Celta";
            novoCarro.speed = 256;

            Console.WriteLine($"{novoCarro.nome}\n{novoCarro.speed}Km/h");
        }
    }
}