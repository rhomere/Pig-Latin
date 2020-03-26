using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pig Latin App - English to Pig Latin\n");
            Console.Write("Enter: ");
            var input = Console.ReadLine();
            var words = input.Split(' ');
            var newWords = new List<string>();
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            var firstLetter = Char.MinValue;
            var letterBeforeFirstVowel = string.Empty;

            foreach (var word in words)
            {
                // Get first vowel
                foreach (var character in word)
                {
                    if (vowels.Contains(character))
                    {
                        firstLetter = character;
                        break;
                    }
                    else
                    {
                        letterBeforeFirstVowel += character;
                    }
                }

                if (firstLetter == Char.MinValue)
                {
                    continue;
                }

                var editedWord = word.Substring(word.IndexOf(firstLetter), word.Length - letterBeforeFirstVowel.Length);
                var newWord = string.Empty;
                if (letterBeforeFirstVowel == "")
                {
                    newWord = editedWord + letterBeforeFirstVowel + "yay ";
                }
                else
                {
                    newWord = editedWord + letterBeforeFirstVowel + "ay ";
                }
                letterBeforeFirstVowel = string.Empty;
                newWords.Add(newWord);
            }

            Console.Write("Result: ");

            foreach (var word in newWords)
            {
                Console.Write(word);
            }
        }
    }
}
