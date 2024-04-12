

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
    
string[] test = { "Sofia", "Pleven" };
string result = Repeat(test);
Console.WriteLine(result);



