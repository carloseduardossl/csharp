using System;
namespace myApp
{
    interface Ianimal
    {
        void AnimalSong();
        void sleep();
    }

    interface InichoEcologico
    {
        void habito();
    }

    class Dog : Ianimal, InichoEcologico
    {
        public void AnimalSong()
        {
            Console.WriteLine("au au");
        }
        public void sleep()
        {
            Console.WriteLine("ZzZzZzZZzZz");
        }
        public void habito()
        {
            Console.WriteLine("reproduction");
        }
    }
}