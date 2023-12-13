bool emailValidacao = true;
string email = "emailtest@gmail.com";
if (!email.Contains("@"))
    emailValidacao = false;
else
{
    string[] emailDividido = email.Split("@");
        if(emailDividido.Length.Equals(2))
        {
            emailValidacao = true;
        }
    string parte2Email = emailDividido[1];
    string parte1Email = emailDividido[0]?.Trim();
    bool test = parte2Email.Contains(".com");
    foreach(char letra in parte2Email){
        if (char.IsNumber(letra)){
            emailValidacao = false;
            break;
        }
    }
    Console.WriteLine(test);
}
Console.WriteLine($"esse email é {(emailValidacao ? "valido" : "invalido")}");
