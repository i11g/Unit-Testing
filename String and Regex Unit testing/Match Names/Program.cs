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

string names = "Elvis Presley a a C C-Muhammad Ali EE PeterpeterJR-a a xi ban D D bb b b-B B-c c EE-Michael Jackson DD peter smith " +
    "B B PETER BROWN IVAN DAVIES- ";
string result = Match(names);
Console.WriteLine(result);
