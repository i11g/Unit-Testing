using System.Text.RegularExpressions;

static string Match(string? dates)
{
    if (dates is null)
    {
        throw new ArgumentException("Input cannot be null!");
    }

    Regex pattern = new(@"\b(?<day>\d{2})(?<seperator>[-.\/])(?<month>[A-Z][a-z]+)\k<seperator>(?<year>\d{4})");

    MatchCollection matches = pattern.Matches(dates);

   foreach (Match match in matches)
    {
        string day = match.Groups["day"].Value;
        string month = match.Groups["month"].Value;
        string year = match.Groups["year"].Value;

       return $"Day: {day}, Month: {month}, Year: {year}";
    }

    return string.Empty;
}

string input = "13/Jul/1928, 10-Nov-1934, 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016 ";
string result = Match(input);
Console.WriteLine(result);
