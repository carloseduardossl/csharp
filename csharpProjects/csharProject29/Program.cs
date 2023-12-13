using System.Runtime.CompilerServices;

static void MeuMetodo (){
    Console.WriteLine("olaaaaaaaa");
}

static void Teste (string nome)
{
    Console.WriteLine($"Ola {nome}");
}
Teste("Bianca");

static void Teste2 (string name, int old, string location)
{
    Console.WriteLine($"Ola {name}! voce tem {old} anos de idade e mora em {location}");
}

Teste2("Bia", 21, "Salvador");

static int Numeros (int x, int y) 
{
    return x + y;
}
Console.WriteLine(Numeros(333, 333));

int b = Numeros(333, 333);
Console.WriteLine(b);

static void Sorteio(string name1, string name2, string name3)
{
    Console.WriteLine($"a pessoa sorteada foi {name2}");
}

Sorteio(name1: "Rafael", name2: "Kassandra", name3: "Lisan");