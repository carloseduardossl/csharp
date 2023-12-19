//Scop and reference type

int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
ClearArray(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}
void ClearArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}