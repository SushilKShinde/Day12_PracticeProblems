using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_PracticeProblem
{
    internal class ReverseString
    {
        public static void StringReverse()
        {
            string str = "Hello World";
            Console.WriteLine($"Before Reverse: {str}");
            Console.Write("\nAfter Reverse: ");
            for (int i= str.Length-1; i>=0; i--)
            {
                for(int j=str.Length-1; j>=0; j--)
                {
                    Console.Write(str[i]);
                    break;
                }
            }
        }
    }
}
