class Program
{
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Denied Access! You must be least 18 years old.");
        }
        else
        {
            Console.WriteLine("Access granted - You are old enough");
        }
    }

    static void Main(string[] args)
    {
        CheckAge(20);
    }
}