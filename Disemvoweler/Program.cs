using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Disemvowel(input);

            Console.ReadKey();
        }

        static void Disemvowel(string input)
        {
            string vowels = "aeiou";
            string inputVowels = string.Empty;
            string inputConsonants = string.Empty;

            foreach (var letter in input)
            {
                if (letter == ' ')
                {
                    continue;
                }
                else if (vowels.Contains(letter))
                {
                    inputVowels += letter;
                }
                else
                {
                    inputConsonants += letter;
                }
            }

            Console.WriteLine(inputConsonants);
            Console.WriteLine(inputVowels);
        }
    }
}
