using System;
namespace myApp
{
    class Animal
    {
        public virtual void AnimalSong()
        {
            Console.WriteLine("Os Animais fazem alguns sons.");
        }
    }
    class Pig : Animal
    {
        public override void AnimalSong ()
        {
            Console.WriteLine($"O porco faz: woink!!");
        }
    }
    class Cat : Animal
    {
        public override void AnimalSong()
        {
            Console.WriteLine("O gato faz: Meow");
        }
    }
}