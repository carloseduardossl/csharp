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

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"A circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircunference(radius);
}


PrintCircleInfo(10);

