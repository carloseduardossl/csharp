// Desenvolvendo estruturas foreach, if-elseif-else para processar dados de Array's

// inicializacao de variaveis 

int tarefas = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 97;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85; 
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiasoma = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int andrewsoma = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
int emmasoma = emma1 + emma2 + emma3 + emma4 + emma5;
int logansoma = logan1 + logan2 + logan3 + logan4 + logan5;

decimal sophiamedia= (decimal)sophiasoma / tarefas;
decimal andrewmedia=(decimal)andrewsoma / tarefas;
decimal emmamedia=(decimal)emmasoma / tarefas;
decimal loganmedia=(decimal)logansoma / tarefas;

Console.WriteLine($"Estudantes \t\tNota\n");
Console.WriteLine($"Sophia:\t\t{sophiamedia}\tA-");
Console.WriteLine($"Andrew:\t\t{andrewmedia}\tB+");
Console.WriteLine($"Emma:\t\t{emmamedia}\tB");
Console.WriteLine($"Logan:\t\t{loganmedia}\tA-\n");
Console.WriteLine($"Pressione a tecla Enter para continuar");
Console.ReadLine();
