// int a = 0;
// while (a < 10)
// {
//     Console.WriteLine(a);
//     a++;
// }

// int b = 0;
// do {
//     Console.WriteLine(b);
//     b++;
// } while (b < 15);

// for (int i = 0; i <= 10; i = i + 2)
// {
//     Console.WriteLine(i);
// }

// for (int c = 0; c <= 2; c++)
// {
//     Console.WriteLine($"externo: {c}");
//     for (int d = 0; d <= 3; d++)
//     {
//         Console.WriteLine($"interno: {d}");
//     }
// }

int i = 0;
while (i <= 10)
{
    if (i == 5)
    {
        i++;
        continue;
    }
    Console.WriteLine(i);
    i++;
}

int num = 0;
while (num < 100)
{
    if (num > 55)
    {
        Console.WriteLine("maior que 55");
        break;
    }
    Console.WriteLine(num);
    num++;
}
