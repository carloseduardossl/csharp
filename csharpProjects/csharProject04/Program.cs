// boletim de um estudante

string nomeEstudante = "Isabella Meireles";

// nome das materias

string materia1 = "English";
string materia2 = "Portuguese";
string materia3 = "Computer Science I";
string materia4 = "Psychology";

// notas

decimal materia1nota1 = 7.6m;
decimal materia1nota2 = 8.4m;
decimal materia1nota3 = 6.4m;

decimal materia2nota1 = 4.5m;
decimal materia2nota2 = 9.9m;
decimal materia2nota3 = 7.6m;

decimal materia3nota1 = 5.5m;
decimal materia3nota2 = 7.7m;
decimal materia3nota3 = 9.0m;

decimal materia4nota1 = 4.4m;
decimal materia4nota2 = 10.0m;
decimal materia4nota3 = 7.5m;

decimal materia1soma = materia1nota1 + materia1nota2 + materia1nota3;
decimal materia2soma = materia2nota1 + materia2nota2 + materia2nota3;
decimal materia3soma = materia3nota1 + materia3nota2 + materia3nota3;
decimal materia4soma = materia4nota1 + materia4nota2 + materia4nota3;

decimal materia1media = materia1soma / 3;
decimal materia2media = materia2soma / 3;
decimal materia3media = materia3soma / 3;
decimal materia4media = materia4soma / 3;

materia1media = Math.Round(materia1media, 1);
materia2media = Math.Round(materia2media, 1);
materia3media = Math.Round(materia3media, 1);
materia4media = Math.Round(materia4media, 1);

decimal somageral = materia1media + materia2media + materia3media + materia4media;
decimal mediageral = (somageral / 4);
mediageral = Math.Round(mediageral, 1);

Console.WriteLine($"Nome do estudante:\t{nomeEstudante}\n");
Console.WriteLine($"Materias:\t\t\t AV1:\t\tAV2:\t\tAV3:\t Media Final:");
Console.WriteLine($"{materia1}\t\t\t\t{materia1nota1}\t\t{materia1nota2}\t\t{materia1nota3}\t\t{materia1media}");
Console.WriteLine($"{materia2}\t\t\t{materia2nota1}\t\t{materia2nota2}\t\t{materia2nota3}\t\t{materia2media}");
Console.WriteLine($"{materia3}\t\t{materia3nota1}\t\t{materia3nota2}\t\t{materia3nota3}\t\t{materia3media}");
Console.WriteLine($"{materia4}\t\t\t{materia4nota1}\t\t{materia4nota2}\t\t{materia4nota3}\t\t{materia4media}");
Console.WriteLine($"Media geral:\t\t{mediageral}");
