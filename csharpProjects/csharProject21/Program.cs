bool emailValidacao = true;
string email = Console.ReadLine();
if (!email.Contains("@"))
    emailValidacao = false;
else
{
    string[] emailDividido = email.Split("@");
    string parte2Email = emailDividido[1];
    if (!parte2Email.Contains(".com"))
        emailValidacao = false;
    else
        emailValidacao = true;
    foreach(char letra in parte2Email){
        if (char.IsNumber(letra)){
            emailValidacao = false;
            break;
        }
    }
}
Console.WriteLine($"esse email é {(emailValidacao ? "valido" : "invalido")}");