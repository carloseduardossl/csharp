// game do Dado
Random dice = new();

int dado1 = dice.Next(1, 7);
int dado2 = dice.Next(1, 7);
int dado3 = dice.Next(1 ,7);

int total = dado1 + dado2 + dado3;

if (dado2 == dado3 )
{
    total++;

    Console.WriteLine("Voce ganhou +1 ponto");
}

if (dado1 == dado2)
{
    total++;
    total++;
    Console.WriteLine("Voce ganhou +2 pontos");
}

Console.WriteLine($"O valor 1: {dado1}");
Console.WriteLine($"O valor 2: {dado2}");
Console.WriteLine($"O valor 3: {dado3}");
Console.WriteLine($"O valor total: {total}");

if (total > 14)
{
    Console.WriteLine("Voce ganhou!!!");
}
if (total < 15)
{
    Console.WriteLine("Desculpa! Voce perdeu");
}