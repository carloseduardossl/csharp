string[] words = { "rececar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word} : {(IsPolindrome(word) ? "True" : "false")}");
}

bool IsPolindrome(string word)
{
    for (int i = word.Length - 1; i >= 0; i--)
    {
        string result += word[i];
    }
    if (result == word)
    {
        return true;
    }

}