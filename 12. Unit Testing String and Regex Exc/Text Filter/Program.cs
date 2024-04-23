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

string[] bannedWords = { "one", "teo" };
string input = "one text teo two";
string result = Filter(bannedWords, input);
Console.WriteLine(result);
