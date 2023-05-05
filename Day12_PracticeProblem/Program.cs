using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Day12_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 12 basic problems");
            Console.WriteLine("Choose the option from below");
            Console.WriteLine("1.Find duplicate elements in array\n2.Print unique elements");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FindDuplicate.FindDuplicateInArray();
                    break;
                case 2:
                    int[] arr = { 1, 2, 3, 2, 4, 5, 3, 6, 7, 6, 8 };
                    UniqueElements.PrintUniqueElements(arr);
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}

