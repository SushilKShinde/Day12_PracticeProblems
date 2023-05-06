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
            Console.WriteLine("1.Find duplicate elements in array\n2.Print unique elements\n3.Maximum and minimun element in array\n4.Reverse each element in array\n5.Print Triangle pattern\n6.Print Hollow Square");
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
                case 3:
                    int[] arr1 = { 5, 8, 2, 10, 1, 7 };
                    MaxAndMinInArrayt.MinAndMax(arr1);
                    break;
                case 4:
                    ReverseString.StringReverse();
                    break;
                case 5:
                    TrianglePattern.PrintPattern();
                    break;
                case 6:
                    HollowSquare.PrintPattern();
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}

