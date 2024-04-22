static List<int> SumPairs(List<int> numbers)
{
    List<int> result = new();

    for (int i = 0; i < numbers.Count / 2; i++)
    {
        result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
    }

    if (numbers.Count % 2 != 0)
    {
        result.Add(numbers[numbers.Count / 2]);
    }

    return result;
}
List<int> numbers= Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> num = SumPairs(numbers);
Console.WriteLine(string.Join(" ",num));