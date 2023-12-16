using System;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Gemini";
            Console.WriteLine(myObj.Name);
        }
    }
}