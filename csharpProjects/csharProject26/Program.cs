// int[,] array1 = { { 1, 2, 3}, { 4, 5, 6 } };
// int[,] array2 = { { 1, 2, 3 }, { 4, 5, 6 } };

// int[,] arraySoma = {{array1[0,0] + array2[0,0], array1[0,1] + array2[0,1], array1[0,2] + array2[0,2]}, {array1[1, 0] + array2[1, 0], array1[1,1] + array2[1,1], array1[1, 2] + array2[1, 2]}};
// foreach (int n in arraySoma)
// {
//     Console.Write($"{n} ");
// }

int[,] arrayMult1 = { { 2, 3 }, { 1, 4 } };
int[,] arrayMult2 = { { 5, 2 }, { 4, 2 } };

int linhas = arrayMult1.GetLength(0);
int colunas = arrayMult2.GetLength(1);

int[,] multiplicacao = new int[linhas, colunas];

for (int a = 0; a < linhas; a++)
{
    for (int b = 0; b < colunas; b++)
    {
        multiplicacao[a, b] = arrayMult1[a, b] * arrayMult2[a, b];
    }
}
foreach (int n in multiplicacao)
{
    Console.WriteLine(n);
}