﻿using System.Text;

static string FindOdd(string[] input)
{
    Dictionary<string, int> oddWords = new();

    foreach (string word in input)
    {
        string wordLower = word.ToLower();

        oddWords.TryAdd(wordLower, 0);
        oddWords[wordLower]++;
    }

    StringBuilder sb = new();
    foreach (KeyValuePair<string, int> word in oddWords)
    {
        if (word.Value % 2 != 0)
        {
            sb.Append($"{word.Key} ");
        }
    }

    return sb.ToString().Trim();
}
//string[] input = Console.ReadLine().Split(' ').ToArray();
string[] input = {"Java", "C#", "PHP", "PHP", "JAVA", "C", "java"}; 

string result=FindOdd(input);
Console.WriteLine(result);