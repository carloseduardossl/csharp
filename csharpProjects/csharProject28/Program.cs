int[] numeros = [ 8, 7, 6, 5, 4, 3];
int n = numeros.Length;

for (int a = 0; a < n - 1; a++)
{
    for (int b = 0; b < n - a - 1; b++)
    {
        if(numeros[b]>numeros[b + 1])
        {
            int temporario = numeros[b];
            numeros[b] = numeros[b + 1];
            numeros[b + 1] = temporario;
        }
    }
}
foreach (int num in numeros)
{
    Console.WriteLine(num);
}