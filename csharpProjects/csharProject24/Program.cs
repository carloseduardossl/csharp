using System.Linq;
int[] operacaoArray = {1, 2, 3, 4};
int[] array2 = {9, 8, 7, 6};
Console.Write(operacaoArray.Sum());
Console.Write(operacaoArray.Max());
Console.WriteLine(operacaoArray.Min());

int[] num = {1, 2, 4, 7, 6, 8};
Array.Sort(num);
foreach (int i in num)
{
    Console.WriteLine(i);
}