static string Filter(string[] bannedWords, string text)
{
    foreach (string word in bannedWords)
    {
        if (text.Contains(word))
        {
            text = text.Replace(word, new string('*', word.Length));
        }
    }

    return text;
}
string[] input = { "Sofia", "Varna" };
string text = "Sofia,Varna,Pleven,Sofia";
string result=Filter(input, text);
Console.WriteLine(result);