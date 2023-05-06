using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_PracticeProblem
{
    internal class HollowSquare
    {
        public static void PrintPattern()
        {
            Console.WriteLine("Enter the size of the square");
            int size = Convert.ToInt32(Console.ReadLine());

            for(int row=0; row<size; row++)
            {
                for( int column =0; column<size; column++)
                {
                    if(row==0 || row==size-1 || column == 0 || column== size-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();    
            }
        }
    }
}
