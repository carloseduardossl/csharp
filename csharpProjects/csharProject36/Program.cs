int a = 3;
int b = 4;
int c = 0;
Multiply(a, b, c);
Console.WriteLine($"global statement: {a} X {b} = {c}");

void Multiply (int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside the Multiply method: {a} X {b} = {c}");
}
