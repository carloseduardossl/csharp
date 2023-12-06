// MATRIZES 
string[] orderIDs = new string[3];

orderIDs[0] = "EDU";
orderIDs[1] = "ISA";
orderIDs[2] = "FIl";
//orderIDs[3] = "GGG";

Console.WriteLine(orderIDs[2]);

// simplificada

string[] matriz  = {"CARLOS", "ISABELLA", "ARTHUR"};
Console.WriteLine($"frist: {matriz[0]}");
Console.WriteLine($"Second: {matriz[1]}");
Console.WriteLine($"Third: {matriz[2]}");

matriz[0] = "EDU";

Console.WriteLine($"Realocando dado 01: {matriz[0]}");

Console.WriteLine($"Numero de pessoas dentro da matriz: {matriz.Length}");

// FOREACH

string[] nomes = {"CARLOS", "ANDRESSA", "DARLA", "CAIO", "VIVIANE"};
foreach (string nome in nomes)
{
    Console.WriteLine(nome);   
}

