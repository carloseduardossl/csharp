// Codigo escrito pelo Gilberto

bool cepValido = true;
string cep = "22790-540";

string[] vetorCep = cep.Split("-");

if (!vetorCep.Length.Equals(2))
{
    Console.WriteLine("O cep está inválido");
    return;
}

string parte1 = vetorCep[0];
string parte2 = vetorCep[1];

if (!parte1.Length.Equals(5))
{
    Console.WriteLine("O cep está inválido");
    return;
}

if (!parte2.Length.Equals(3))
{
    Console.WriteLine("O cep está inválido");
    return;
}

foreach (char item in parte1)
    if (!char.IsNumber(item))
    {
        cepValido = false;
        break;
    }

if (cepValido)
    foreach (char item in parte2)
        if (!char.IsNumber(item))
        {
            cepValido = false;
            break;
        }

Console.WriteLine($"O cep é {(cepValido ? "válido" : "inválido")}");