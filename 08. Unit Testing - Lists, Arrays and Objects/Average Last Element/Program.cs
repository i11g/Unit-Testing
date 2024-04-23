int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int num=int.Parse(Console.ReadLine());
int length = numbers.Length;
int newLength=length-num;
double sum = 0;
for (int i =numbers.Length-1; i>=newLength; i--)
{
    sum += numbers[i];
}
Console.WriteLine($"{(double)sum/num:f2}");
