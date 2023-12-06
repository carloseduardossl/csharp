// game do Dado
Random dice = new();

int dado1 = dice.Next(1, 7);
int dado2 = dice.Next(1, 7);
int dado3 = dice.Next(1 ,7);

int total = dado1 + dado2 + dado3;

Console.WriteLine($"O valor 1: {dado1}");
Console.WriteLine($"O valor 2: {dado2}");
Console.WriteLine($"O valor 3: {dado3}");
Console.WriteLine($"O valor total: {total}");
