using System.Text;

static string GeneratePatternedString(string input, int repetitionFactor)
{
    if (string.IsNullOrEmpty(input) || repetitionFactor <= 0)
    {
        throw new ArgumentException("Input string cannot be empty, and repetition factor must be positive.");
    }

    StringBuilder result = new();
    for (int i = 0; i < repetitionFactor; i++)
    {
        for (int j = 0; j < input.Length; j++)
        {
            char currentChar = j % 2 == 0 ? char.ToLower(input[j]) : char.ToUpper(input[j]);
            result.Append(currentChar);
        }
    }

    return result.ToString();
}
string input = "Sofia";
int repetition = 2;
string result = GeneratePatternedString(input, repetition);
Console.WriteLine(result);
