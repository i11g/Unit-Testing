static string[] ReverseStrings(string[] arr)
{
    return arr.Select(s => new string(s.Reverse().ToArray())).ToArray();
}
string[] arr=Console.ReadLine().Split(' ').ToArray();
string [] result = ReverseStrings (arr);
Console.WriteLine(string.Join(" ",result));
