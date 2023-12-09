string nome = Console.ReadLine();
static void Boasvindas(string nome) => Console.WriteLine($"Ola, {nome}!\nSeja bem vindo(a)!");
Boasvindas(nome);

Console.WriteLine("Diga um numero:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Diga outro numero:");
int b = Convert.ToInt32(Console.ReadLine());

static void Somar(int a, int b) => Console.WriteLine($"A soma e: {a + b}");
Somar(a, b);