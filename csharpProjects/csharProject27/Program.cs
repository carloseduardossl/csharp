using System.Runtime.Serialization.Formatters;

int[,] array1 = { { 2, 3 }, { 4, 1 } };
int[,] array2 = { { 5, 7 }, { 7, 8 } };

int linha1 = array1.GetLength(0);
int coluna1 = array1.GetLength(1);
int linha2 = array2.GetLength(0);
int coluna2 = array2.GetLength(1);

int[,] multiplicacao = new int[linha1, coluna2];

for (int a = 0; a < linha1; a++)
{
    for (int b = 0; b < coluna2; b++)
    {
        int soma = 0;
        for (int c = 0; c < coluna1; c++)
        {
            soma += array1[a, c] * array2[c, b];
        }
        multiplicacao[a, b] = soma;
    }
}
for (int a = 0; a < linha1; a++)
{
    for (int b = 0; b < coluna2; b++)
    {
        Console.WriteLine($"{multiplicacao[a, b]} ");
    }
}