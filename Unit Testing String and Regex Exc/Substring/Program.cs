﻿static string RemoveOccurrences(string toRemove, string input)
{
    int removeIndex = input.IndexOf(toRemove, StringComparison.OrdinalIgnoreCase);
    while (removeIndex > -1)
    {
        input = input.Remove(removeIndex, toRemove.Length);
        removeIndex = input.IndexOf(toRemove, StringComparison.OrdinalIgnoreCase);
    }

    while (input.Contains("  "))
    {
        input = input.Replace("  ", " ");
    }

    return input.Trim();
}

string toRemove = "Pleven";
string input = "SofiaPlevenSofiaPl";
string result=RemoveOccurrences(toRemove, input);
Console.WriteLine(result);