decimal n1 = 5.6m;
decimal n2 = 7.6m;
decimal n3 = 8.2m;

decimal soma = n1 + n2 + n3;
decimal media = soma / 3;
media = Math.Round(media, 1);
Console.WriteLine($"A media do alundo e {media}");