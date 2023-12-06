using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
