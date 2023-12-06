// game do Dado
Random dice = new();

int dado1 = dice.Next(1, 7);
int dado2 = dice.Next(1, 7);
int dado3 = dice.Next(1 ,7);

int total = dado1 + dado2 + dado3;

if ((dado1 == dado2) && (dado2==dado3))
{
    Console.WriteLine("TRIPLES ROLL'S!!! Voce ganhou +3 pontos");
    total += 3;
}

if ((dado1 == dado2) || (dado2 == dado3) || (dado1 == dado3))
{
    Console.WriteLine("Doubles rolls!!! +2 pontos adicionais");
    total += 2;
}

Console.WriteLine($"O valor 1: {dado1}");
Console.WriteLine($"O valor 2: {dado2}");
Console.WriteLine($"O valor 3: {dado3}");
Console.WriteLine($"O valor total: {total}");

if (total >= 15)
{
    Console.WriteLine("Voce ganhou!!!");
}
if (total < 15)
{
    Console.WriteLine("Desculpa! Voce perdeu");
}