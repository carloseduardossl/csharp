// Desenvolvendo estruturas foreach, if-elseif-else para processar dados de Array's
// inicializacao de variaveis 

int tarefas = 5;

int[] sophiaNotas = {90, 86, 87, 98, 100};
int[] andrewNotas = {92, 89, 81, 96, 90};
int[] emmaNotas = {90, 85, 87, 98, 68};
int[] loganNotas = {90, 95, 87, 88, 96};

Console.WriteLine($"Estudantes \t\tNota\n");
string[] nomesEstudantes = {"Sophia", "Andrew", "Emma", "Logan"};
foreach (string nome in nomesEstudantes)
    {
        if(nome == "Sophia"){
            int sophiaSoma = 0;
            decimal sophiaMedia;
            foreach(int nota in sophiaNotas){
                sophiaSoma += nota;
            }
            sophiaMedia = (decimal)sophiaSoma / tarefas;
            Console.WriteLine($"Sophia:\t\t{sophiaMedia}\tA-");
        }
        if(nome == "Andrew"){
            int andrewSoma = 0;
            decimal andrewMedia;
            foreach(int nota in andrewNotas){
                andrewSoma += nota;
            }
            andrewMedia = (decimal)andrewSoma / tarefas;
            Console.WriteLine($"Andrew:\t\t{andrewMedia}\tB+");
        }
        if(nome == "Emma"){
            int emmaSoma = 0;
            decimal emmaMedia;
            foreach(int nota in emmaNotas){
                emmaSoma += nota;
            }
            emmaMedia = (decimal)emmaSoma / tarefas;
            Console.WriteLine($"Emma:\t\t{emmaMedia}\tB");
        }
        if(nome == "Logan"){
            int loganSoma = 0;
            decimal loganMedia;
            foreach(int notas in loganNotas){
                loganSoma += notas;
            }
            loganMedia = (decimal)loganSoma / tarefas;
            Console.WriteLine($"Logan:\t\t{loganMedia}\tA-\n");
        }
    }
Console.WriteLine($"Pressione a tecla Enter para continuar");
Console.ReadLine();
