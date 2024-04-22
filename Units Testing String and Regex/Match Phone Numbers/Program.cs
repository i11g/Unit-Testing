using System.Text.RegularExpressions;

static string Match(string phones)
{
    Regex pattern = new(@"\+359(?<seperators>[ -])2\k<seperators>[0-9]{3}\k<seperators>[0-9]{4}\b");
    MatchCollection matches = pattern.Matches(phones);

    return string.Join(", ", matches.Select(x => x.Value.Trim()).ToArray());
}
string input = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
string result=Match(input);
Console.WriteLine(result);