using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_PracticeProblem
{
    internal class MaxAndMinInArrayt
    {
        public static void MinAndMax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];

            for (int i=1; i<arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Minimum element:{min} ");
            Console.WriteLine($"Maximum element:{max} ");
        }
    }
}
