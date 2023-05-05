using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_PracticeProblem
{
    public class TrianglePattern
    {
        public static void PrintPattern()
        {
            int n = 6;
            for (int i=n; i>0; i--)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }            
        }
    }
}
