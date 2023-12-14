public class Car
{
    string color;
    int speed;
    string nome;

    static void Main(string[] args)
    {
        Car myObj = new Car();
        myObj.speed = 200;
        myObj.color = "Blue";
        myObj.nome = "Sienna";

        Console.WriteLine($"The car name is {myObj.nome}, and your color is {myObj.color}\n and your max speed is  {myObj.speed}Km/h");


        Car meuNovoCarro = new Car();
        meuNovoCarro.color = "yellow";
        meuNovoCarro.nome = "Phobos";
        meuNovoCarro.speed = 200; // LOL

        Console.WriteLine($"{meuNovoCarro.nome}\n {meuNovoCarro.speed}\n {meuNovoCarro.color}");
    }
}