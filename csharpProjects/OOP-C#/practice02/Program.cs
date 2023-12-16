using System;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car("F11","Tourning","BMW");
            Console.WriteLine($"{myObj.Name} {myObj.Brand} {myObj.Model}");
            myObj.Song();
        }
    }
}