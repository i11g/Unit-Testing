using System.Text.RegularExpressions;

static List<string> ExtractUrls(string text)
{
    string pattern = @"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&=]*)";
    Regex regex = new(pattern);

    MatchCollection matches = regex.Matches(text);

    List<string> urls = new();

    foreach (Match match in matches)
    {
        urls.Add(match.Value);
    }

    return urls;
}

string input = "http://www.example.com, https://www.google.com, www.example.com";
List<string> result=ExtractUrls(input);
foreach (string url in result)
{
    Console.WriteLine(string.Join(",",url));
}