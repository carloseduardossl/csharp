string[] cars = { "Volvo", "Celta", "BMW", "Ford" };
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

foreach (string i in cars)
{
    Console.WriteLine($"usando o foreach: {i}");
}