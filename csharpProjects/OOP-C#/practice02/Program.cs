using System;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine($"{myObj.Name} {myObj.Brand}");
            myObj.Song();
        }
    }
}