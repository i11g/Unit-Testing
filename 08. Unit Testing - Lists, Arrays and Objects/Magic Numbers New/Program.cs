int number=int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <=number; i++)
{
    int currentNumber = i;
    bool isPrime=true;
    sum = 0;

    while (currentNumber != 0)
    {
        int lastDigit = currentNumber % 10;

        if (lastDigit ==0 || lastDigit == 1 || lastDigit == 4 || lastDigit == 6||lastDigit==8||lastDigit==9)
        {
            isPrime = false;
            break;
        }
        else
        {
            sum += lastDigit;
        }
        currentNumber/=10;
    }
    if (!isPrime)
    {
        continue;
    }
    else
    {
        if (sum % 2 == 0)
        {
            Console.Write(i+" ");
        }
    }
    
}

