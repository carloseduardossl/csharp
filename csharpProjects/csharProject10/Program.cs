// Desafio do if, else, elseif, foreach e array
string[] elementos = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
int withb = 0;
foreach (string code in elementos)
{
    withb++;
    if(code.StartsWith("B")){
        Console.WriteLine($"o indice {withb} comeca com B: {code}");
    }
}