using System;
namespace myApp
{
    abstract class  Animal
    {
        public abstract void AnimalSong ();
        public void sleep()
        {
            Console.WriteLine("zZzzzZZzz");
        }
    }
    class Dog : Animal
    {
        public override void AnimalSong()
        {
            Console.WriteLine("au au");
        }
    }
}