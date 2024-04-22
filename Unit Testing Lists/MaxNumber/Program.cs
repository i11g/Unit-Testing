static int FindMax(List<int> numbers)
{
    if (numbers == null || numbers.Count == 0)
    {
        throw new ArgumentException("Input list is empty or null.");
    }

    return numbers.Max();
}

List<int> numbers= Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int result=FindMax(numbers);
Console.WriteLine(result);