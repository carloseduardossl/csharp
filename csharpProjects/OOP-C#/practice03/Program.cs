using System;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Pig porco = new Pig();
            Cat gato = new Cat();

            animal.AnimalSong();
            porco.AnimalSong();
            gato.AnimalSong();

        }
    }
}