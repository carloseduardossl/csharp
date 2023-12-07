// Desenvolvendo estruturas foreach, if-elseif-else para processar dados de Array's

// inicializacao de variaveis 

int tarefas = 5;

int[] sophia = {90, 86, 87, 98, 100};
int sophiaSoma = 0;
foreach(int notas in sophia)
{
    sophiaSoma += notas;
}

int[] andrew = {92, 89, 81, 96, 90};
int andrewSoma = 0;
foreach (int notas in andrew)
{
    andrewSoma += notas;
}

int[] emma = {90, 85, 87, 98, 68};
int emmaSoma = 0;
foreach (int notas in emma)
{
    emmaSoma += notas;
}

int[] logan = {90, 95, 87, 88, 96};
int loganSoma = 0;
foreach (int notas in logan)
{
    loganSoma += notas;
}

decimal sophiaMedia= (decimal)sophiaSoma / tarefas;
decimal andrewMedia=(decimal)andrewSoma / tarefas;
decimal emmaMedia=(decimal)emmaSoma / tarefas;
decimal loganMedia=(decimal)loganSoma / tarefas;

Console.WriteLine($"Estudantes \t\tNota\n");
Console.WriteLine($"Sophia:\t\t{sophiaMedia}\tA-");
Console.WriteLine($"Andrew:\t\t{andrewMedia}\tB+");
Console.WriteLine($"Emma:\t\t{emmaMedia}\tB");
Console.WriteLine($"Logan:\t\t{loganMedia}\tA-\n");
Console.WriteLine($"Pressione a tecla Enter para continuar");
Console.ReadLine();
