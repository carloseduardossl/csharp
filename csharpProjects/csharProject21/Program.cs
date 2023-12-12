string email = Console.ReadLine();
string[] validacao = email.Split("@",".com");

Console.WriteLine(validacao[1]);