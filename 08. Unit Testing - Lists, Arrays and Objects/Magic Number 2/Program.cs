using System.Diagnostics.CodeAnalysis;

int num=int.Parse(Console.ReadLine());
bool noSuchNubers = false;

for (int i = 1; i <=num ; i++)
{
    int sum = 0;
    int currentNumber = i;
    bool allNumbersPrime = true;
    while (currentNumber>0)
    {
        
        int lastDigit = currentNumber % 10;
        currentNumber/=10;
        bool isPrime = true;

        if (lastDigit == 0 || lastDigit == 1)
        {

            isPrime = false;
            
        }
        for (int j = 2; j < lastDigit; j++)
        {   
            
            if (lastDigit % j == 0)
            {
                isPrime = false;
                break;
            }
           
        }
        if (isPrime)
        {
            sum+=lastDigit; 
        }
        else
        {
            allNumbersPrime = false;
        }

    }
    if(allNumbersPrime&&sum%2==0)
    {
        Console.Write(i+" ");
        noSuchNubers=true;
    }   
    
}
if (!noSuchNubers )
{
    Console.WriteLine("no");
}
