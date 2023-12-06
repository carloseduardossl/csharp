Random dice = new();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"Primeriro {roll1}");
Console.WriteLine($"Segundo {roll2}");
Console.WriteLine($"Terceorp {roll3}");
