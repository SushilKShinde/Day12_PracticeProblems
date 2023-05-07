using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Day12_PracticeProblem
{
    internal class FirstLetterCapital
    {
        public static void MakeFirstLetterCapital()
        {
            Console.WriteLine("Enter the sentence ");
            String str = Console.ReadLine();
            string[] words = str.Split(' '); // splits by space 

            
               for(int i=0; i<words.Length; i++)
                {
                   string word = words[i];
                    if (!string.IsNullOrEmpty(word))
                    {
                        char fst = char.ToUpper(word[0]);
                        string remainingWord = word.Substring(1);

                       words[i] = fst + remainingWord;
                    } 
                  
                }
            Console.WriteLine($"New sentence: {String.Join(" ", words)} ");
        }
    }
}
