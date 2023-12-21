string ReverseWord (string word)
{
    string result = "";
    for(int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    Console.WriteLine(result);
    return result;
}
string word = "Carlos";
ReverseWord(word);