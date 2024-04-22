int num=int.Parse(Console.ReadLine());
int sumFactorials = 0;
while(num > 0)
{
    int lastDigit = 0;
    lastDigit = num % 10;
    int factorial = 1;
    if(lastDigit%2==0)
    {
        for(int i = 1; i <=lastDigit; i++)
        {
            factorial *= i;
        }
        sumFactorials += factorial;
    }
    num /= 10;
}
Console.WriteLine(sumFactorials);