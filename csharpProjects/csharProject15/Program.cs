int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
static void Somar(int a, int b) 
{
    int soma = a - b;
    int c = Math.Abs(soma);
    if(c > a)
        Console.WriteLine($"o nummero {c} e maior que {a}");
    else if(c < a && c < b)
        Console.WriteLine($"O numero e negativo");
    else if (c < a)
        Console.WriteLine($"o numero {c} e menor que {a}");
}
Somar(a, b);