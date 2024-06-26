﻿static int FindDifference(int[] arr)
{
    int evenSum = 0;
    int oddSum = 0;

    foreach (int number in arr)
    {
        if (number % 2 == 0)
        {
            evenSum += number;
        }
        else
        {
            oddSum += number;
        }
    }

    return Math.Abs(evenSum - oddSum);
}
int[] arr= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int result = FindDifference(arr);
Console.WriteLine(result);