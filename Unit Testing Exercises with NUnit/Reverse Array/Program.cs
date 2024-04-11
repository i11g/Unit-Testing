static string ReverseArray(int[] arr)
{
    Array.Reverse(arr);
    return string.Join(" ", arr);
}

int[] array=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
string result = ReverseArray(array);
Console.WriteLine(result);