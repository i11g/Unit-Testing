static char[] RemoveStringNumbers(char[]? arr)
{
    if (arr is null)
    {
        throw new ArgumentException("Array can't be null.");
    }

    return arr.Where(c => !char.IsDigit(c)).ToArray();
}
char[] array=Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
char[] result = RemoveStringNumbers(array);
Console.WriteLine(string.Join(" ",result));