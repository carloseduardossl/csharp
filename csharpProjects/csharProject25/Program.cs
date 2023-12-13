int[,] numeros = { { 1, 5, 9 }, { 7, 5, 3 } };

Console.WriteLine(numeros.Length);
Console.WriteLine(numeros[1, 2]);

numeros[1, 2] = 10;

Console.WriteLine(numeros[1, 2]);