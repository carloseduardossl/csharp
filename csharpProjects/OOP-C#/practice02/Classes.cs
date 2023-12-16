using System;
namespace myApp
{
    class Vehicle 
    {   
        public string Model
        { get; set; }
        public string Name
        { get; set; }
        public string Brand
        { get; set; }
        public void Song ()
        {
            Console.WriteLine($"{Name}: VRUUMM!! LOL :D");
        }
    }

    class Car : Vehicle
    {
        public Car (string modelo, string nome, string marca)
        {
            Model = modelo;
            Name = nome;
            Brand = marca;
        }
    }

}