using System;
namespace myApp
{
    class Vehicle 
    {   
        public string Name
        { get; set; }
        public string Brand
        { get; set; }
        public void Song ()
        {
            Console.WriteLine($"{Name}VRUUMM!! LOL :D");
        }
    }

    class Car : Vehicle
    {
        public Car(string Name, string Brand) 
        {
            
        }
        
    }

}