string[] pergunta = { "O que é uma string?", "O que é um Int?" };

static void FlashCard(string[] pergunta)
{
    string[] resposta = { "É uma sequencia de caracteres.", "E o tipo primitivo dos numeros inteiros" };

    for (int f = 0; f < pergunta.Length; f++)
    {
        Console.WriteLine($"FlashCard 1:{pergunta[f]}");
        string respostaUsuario = Console.ReadLine();
        int correct = 0;
        if (respostaUsuario == resposta[f])
            correct = 1;
        else
            correct = 0;
    }
}
Console.WriteLine(FlashCard(pergunta[0]));