public class Calculate
{
    public int Addition(int a, int b)
    {
        return a + b;
    }

    public int Subtraction(int a, int b)
    {
        return a - b;
    }
}
public class Program
{
    public static void Main()
    {
        Calculate calculator = new Calculate();

        int result1 = calculator.Addition(5, 3);
        Console.WriteLine("Addition result: " + result1);

        int result2 = calculator.Subtraction(10, 4);
        Console.WriteLine("Subtraction result: " + result2);
    }
}

