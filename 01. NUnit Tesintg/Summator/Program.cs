using System;

namespace Summator
{
    public class Suma
    {   
        public static int Sum (int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0; 
            }
            int sum = nums[0];
            for (int i = 1; i <nums.Length; i++)
            {
                sum += nums[i];              
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum (new int[] {10, 20, 30}));

        }
    }
}