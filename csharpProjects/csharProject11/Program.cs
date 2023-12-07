int tarefas = 5;

int[] sophiaNotas = { 90, 86, 87, 98, 100 };
int[] andrewNotas = { 92, 89, 81, 96, 90 };
int[] emmaNotas = { 90, 85, 87, 98, 68 };
int[] loganNotas = { 90, 95, 87, 88, 96 };


string[] nomesEstudantes = { "Sophia", "Andrew", "Emma", "Logan" };
int[] estudanteNota = new int[10];
string notasLetras = "";

Console.WriteLine($"Estudantes \t\tNota\n");

foreach (string nome in nomesEstudantes)
{
    string estudanteAtual = nome;
    int somaNotas = 0;
    decimal mediaNotas;

    if (nome == "Sophia")
        estudanteNota = sophiaNotas;

    else if (nome == "Andrew")
        estudanteNota = andrewNotas;

    else if (nome == "Emma")
        estudanteNota = emmaNotas;

    else if (nome == "Logan")
        estudanteNota = loganNotas;

    foreach (int notas in estudanteNota)
        somaNotas += notas;

    mediaNotas = (decimal)somaNotas / tarefas;

    if (mediaNotas >= 97)
        notasLetras = "A+";
    else if (mediaNotas >= 93)
        notasLetras = "A";
    else if (mediaNotas >= 90)
        notasLetras = "A-";
    else if (mediaNotas >= 87)
        notasLetras = "B+";
    else if (mediaNotas >= 83)
        notasLetras = "B";
    else if (mediaNotas >= 80)
        notasLetras = "B-";
    else if (mediaNotas >= 77)
        notasLetras = "C+";
    else if (mediaNotas >= 73)
        notasLetras = "C";
    else if (mediaNotas >= 70)
        notasLetras = "C-";
    else if (mediaNotas >= 67)
        notasLetras = "D+";
    else if (mediaNotas >= 63)
        notasLetras = "D";
    else if (mediaNotas >= 60)
        notasLetras = "D-";
    else
        notasLetras = "F";

    if (nome == "Sophia")
    {
        int sophiaSoma = 0;
        decimal sophiaMedia;

        foreach (int nota in sophiaNotas)
        {
            sophiaSoma += nota;
        }
        sophiaMedia = (decimal)sophiaSoma / tarefas;
    }
    if (nome == "Andrew")
    {
        int andrewSoma = 0;
        decimal andrewMedia;
        foreach (int nota in andrewNotas)
            andrewSoma += nota;
        andrewMedia = (decimal)andrewSoma / tarefas;
    }
    if (nome == "Emma")
    {
        int emmaSoma = 0;
        decimal emmaMedia;
        foreach (int nota in emmaNotas)
            emmaSoma += nota;
        emmaMedia = (decimal)emmaSoma / tarefas;
    }
    if (nome == "Logan")
    {
        int loganSoma = 0;
        decimal loganMedia;
        foreach (int notas in loganNotas)
            loganSoma += notas;
        loganMedia = (decimal)loganSoma / tarefas;
    }
    Console.WriteLine($"{nome}\t\t{mediaNotas}\t{notasLetras}");
}
Console.WriteLine($"Pressione a tecla Enter para continuar");
Console.ReadLine();