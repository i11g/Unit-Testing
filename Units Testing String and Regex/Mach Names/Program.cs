using System.Text.RegularExpressions;
using System.Text;

static string Match(string names)
{
    Regex pattern = new(@"\b[A-Z][a-z]+ [A-Z][a-z]+");

    MatchCollection matches = pattern.Matches(names);

    StringBuilder sb = new();
    foreach (Match match in matches)
    {
        sb.Append($"{match.Value} ");
    }

    return sb.ToString().Trim();
}
string names = "John Smith and Alice Johnson";
string result=Match(names).ToString();
Console.WriteLine(result);
