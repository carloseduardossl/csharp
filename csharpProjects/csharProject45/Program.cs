string[] pettingZoo ={
        "alpacas", "capybaras" , "chickens", "duks" , "emus", "geese",
        "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
        "ostrishes", "pigs" , "ponies" , "rabbits", "sheep", "tortoise",
};

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}

RandomizeAnimals();


// AssingnGroup();
//string[,] group = AssisngGroup();
Console.WriteLine("School A");
foreach (string animal in pettingZoo)
{   
    Console.WriteLine(animal);
}
//PrintGroup(group);

