double pi = 3.14159;

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircunference(int radius)
{
    double cirunference = 2 * pi * radius;

    Console.WriteLine($"Circunference = {cirunference}");
}

PrintCircleArea(10);
PrintCircleCircunference(10);