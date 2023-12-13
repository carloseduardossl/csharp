int[,] numeros = { { 1, 5, 9 }, { 7, 5, 3 } };

Console.WriteLine(numeros.Length);
Console.WriteLine(numeros[1, 2]);

numeros[1, 2] = 10;

Console.WriteLine(numeros[1, 2]);

int[,] test1 = { { 1, 2, 3 }, { 2, 3, 4 } };
foreach (int i in test1)
{
    Console.WriteLine(i);
}

int[,] test2 = {{ 1, 2 , 3 }, { 5, 6, 8 }};
for (int i = 0; i < test1.GetLength(0); i++)
{
    for (int j =0; j < test1.GetLength(1); j++)
    {
        Console.WriteLine(test2[i, j]);
    }
}