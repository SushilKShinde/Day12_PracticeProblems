using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_PracticeProblem
{
    internal class SumOfDigits
    {
        public static void FindSumOfDigits()
        {
            Console.WriteLine("Enter an integer number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int sum = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
