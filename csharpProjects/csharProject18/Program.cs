Console.WriteLine( 2 > 1 );
Console.WriteLine( 3 < 2 );
Console.WriteLine( 2 >= 2);
Console.WriteLine( 1 <= 0);

//---------------------------------------------------------------------------------

string email = Console.ReadLine();
if (email.Contains("@gmail.com") || email.Contains("@hotmail.com"))
    Console.WriteLine("esse email e valido");
else 
    Console.WriteLine("esse email e invalido");