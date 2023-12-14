// class Car
// {
//     string nome = "BMW";
//     int maxSpeed = 400;
//     static void Main()
//     {
//         Car novoCarro = new Car();
//         Console.WriteLine(novoCarro.nome);
//         Console.WriteLine(novoCarro.maxSpeed);
//     }
// }

public class Car2
{
    string color;
    int speed;
    string nome;

    static void Main(string[] args)
    {
        Car2 myObj = new Car2();
        myObj.speed = 200;
        myObj.color = "Blue";
        myObj.nome = "Sienna";

        Console.WriteLine($"The car name is {myObj.nome}, and your color is {myObj.color}\n and your max speed is  {myObj.speed}Km/h");
    }
}