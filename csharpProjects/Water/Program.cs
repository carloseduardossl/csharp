Console.WriteLine("Ola! Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual seu peso?");
decimal peso1 = Convert.ToDecimal(Console.ReadLine());
decimal peso2 = (decimal)peso1 / 10; 

static void CalculoDaAgua (decimal peso2)
{
    decimal quantidadeAgua = (35 * peso2) / 1000;
    quantidadeAgua = Math.Round(quantidadeAgua, 1);
    Console.WriteLine($"Diariamente, voce precisa beber {quantidadeAgua}L litros de agua");

}
CalculoDaAgua(peso2);