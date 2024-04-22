static int CalculateFibonacci(int n)
{
    if (n < 0)
    {
        throw new ArgumentException("Input must be a non-negative integer.");
    }

    if (n <= 1)
    {
        return n;
    }

    return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
}
int num = int.Parse(Console.ReadLine());
int result = CalculateFibonacci(num);
Console.WriteLine(result);