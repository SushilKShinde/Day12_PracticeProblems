using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_PracticeProblem
{
   public class FindDuplicate
    {
        public static void FindDuplicateInArray()
        {
            int[] array = { 10, 20, 30, 20, 40, 50, 40, 10, 30 };
            int count = 0, i, j;

            Console.WriteLine("Elements of an array\n");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("*******");
            for (i = 0; i < array.Length - 1; i++)
            {
                for (j = i+1; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("The number of Duplicate Elements Present in Array is={0}", count);
            Console.ReadLine();
        }
    }
}

