Console.WriteLine("Ola! Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual seu peso?(Kg)");
decimal peso1 = Convert.ToDecimal(Console.ReadLine());
decimal peso2 = (decimal)peso1 / 10;

static void CalculoDaAgua(decimal peso2, string nome)
{
    decimal quantidadeAgua = (35 * peso2) / 1000;
    quantidadeAgua = Math.Round(quantidadeAgua, 1);
    Console.WriteLine($"Diariamente, voce precisa beber {quantidadeAgua}L litros de agua");

    Console.WriteLine("Qual a capacidade do seu recipiente de agua? (ml)");
    int recipienteDeAgua = Convert.ToInt32(Console.ReadLine());

    decimal quantidadeRecipiente = (quantidadeAgua / recipienteDeAgua) * 1000;
    quantidadeRecipiente = Math.Round(quantidadeRecipiente, 0);

    Console.WriteLine($"{nome}, voce tera que consumir {quantidadeRecipiente} unidades do seu recipiente\n para bater sua meta diaria");
}

CalculoDaAgua(peso2, nome);
