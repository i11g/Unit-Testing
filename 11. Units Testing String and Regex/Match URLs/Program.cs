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
string url = "http/www.plaven.com";
List<string> result=ExtractUrls(url);
Console.WriteLine(string.Join(",",result));
