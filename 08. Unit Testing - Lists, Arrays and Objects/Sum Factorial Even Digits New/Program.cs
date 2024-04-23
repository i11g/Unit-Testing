int number =int.Parse(Console.ReadLine());

static int CalculateFactorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <=num; i++)
    {
        factorial *= i;
    }
    return factorial;
}


//while(num>0)
//{
//    int result = 1;
//    result = result * num;
//    num--;

//}

int sum = 0;
while(number>0)
{
    int lastDigit = 0;
    lastDigit = number % 10;
    
    if(lastDigit %2== 0)
    {
        sum += CalculateFactorial(lastDigit);
    }
}
Console.WriteLine(sum);