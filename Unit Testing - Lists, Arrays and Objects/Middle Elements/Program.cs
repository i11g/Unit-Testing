//int[] numbers=Console.ReadLine(). Split(' ').Select(int.Parse).ToArray();
//double average = 0;
//double sum = 0;
//for (int i = 0; i < numbers.Length-1; i++)
//{
//    int middleFirstElement = numbers[numbers.Length/2-1];
//    int middleSecondElement = numbers[numbers.Length/2];
//    sum=middleFirstElement+middleSecondElement;
//    average = sum/2.00;
//}
//Console.WriteLine($"{average:f2}");

int[] numbers=Console.ReadLine(). Split(' ').Select(int.Parse).ToArray();
double average = 0;
double sum = 0;

   int middleFirstElement = numbers[numbers.Length / 2 - 1];
   int middleSecondElement = numbers[numbers.Length/2];
    sum=middleFirstElement+middleSecondElement;
    average = sum/2.00;
Console.WriteLine($"{average:f2}");