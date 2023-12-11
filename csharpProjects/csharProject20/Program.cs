string permission = Console.ReadLine();
int level = Convert.ToInt32(Console.ReadLine());

if (permission.Contains("Admin"))
{
    if (level > 55)
        Console.WriteLine("Bem vindo, Super Admin!");
    else
        Console.WriteLine("Bem vindo Admin");
}
else if (permission.Contains("Gerente"))
{
    if (level > 20)
        Console.WriteLine("Contate um Admin para acessar");
    else
        Console.WriteLine("Você não tem privilégio o suficiente para acessar");
}