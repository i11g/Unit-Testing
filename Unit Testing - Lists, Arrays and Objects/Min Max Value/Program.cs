using System.Linq;

int[] numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int num=int.Parse(Console.ReadLine());
int max = int.MinValue; 
int min = int.MaxValue;

for (int i = 0; i <num; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    //max = numbers.Max();
    //min = numbers.Min();
}
Console.WriteLine(max);
Console.WriteLine(min);
