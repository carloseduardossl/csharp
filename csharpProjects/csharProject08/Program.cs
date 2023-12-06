// game do Dado
Random dice = new();

int dado1 = dice.Next(1, 7);
int dado2 = dice.Next(1, 7);
int dado3 = dice.Next(1 ,7);

int total = dado1 + dado2 + dado3;

if ((dado1 == dado2) || (dado2 == dado3) || (dado1 == dado3)){
    if ((dado1 == dado2)&&(dado2 == dado3))
    {
        Console.WriteLine("TRIPLE ROLLS! Voce ganhou 3 pontos");
        total += 3;
    }
    else
    {
        Console.WriteLine("DOUBLE!! Voce ganhou 2 pontos");
        total += 2;
    }
}

if (total >= 15)
{
    Console.WriteLine("Voce ganhou!!!");
}
else
{
    Console.WriteLine("Desculpa! Voce perdeu...");
}
Console.WriteLine($"Rolls:\t{dado1} + {dado2} + {dado3} = {total}");