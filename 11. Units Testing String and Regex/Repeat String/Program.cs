using System.Text;

static string Repeat(string[] input)
{
    StringBuilder sb = new();

    foreach (string s in input)
    {
        string repeatedString = string.Concat(Enumerable.Repeat(s, s.Length));
        sb.Append(repeatedString);
    }

    return sb.ToString().Trim();
}
string[] input = { "abd", "as", "gf" };
string result = Repeat(input);
Console.WriteLine(string.Join(" ", result));



