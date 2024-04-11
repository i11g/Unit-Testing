static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

string word=Console.ReadLine();
string reversed=Reverse(word);
Console.WriteLine(reversed);

