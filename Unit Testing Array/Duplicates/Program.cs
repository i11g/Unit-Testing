static int[] RemoveDuplicates(int[] numbers)
{
    HashSet<int> uniqueNumbers = new();

    foreach (int number in numbers)
    {
        uniqueNumbers.Add(number);
    }

    return uniqueNumbers.ToArray();
}
int[] numbers= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] result = RemoveDuplicates(numbers);
Console.WriteLine(string.Join(" ",result));