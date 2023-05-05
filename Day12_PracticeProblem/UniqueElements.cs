using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_PracticeProblem
{
    public class UniqueElements
    {
        public static void PrintUniqueElements(int[] arr)
        {
            Console.WriteLine("Array elements\n");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\nArray unique elements\n");
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }
    }
}
