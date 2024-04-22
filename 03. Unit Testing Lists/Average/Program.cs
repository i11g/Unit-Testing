static double CalculateAverage(int[] numbers)
{
    if (numbers.Length == 0)
    {
        throw new ArgumentException("Input array cannot be empty.");
    }

    int sum = 0;

    foreach (int number in numbers)
    {
        sum += number;
    }

    return (double)sum / numbers.Length;
}

int[] numbers= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
double result = CalculateAverage(numbers);
Console.WriteLine(result);