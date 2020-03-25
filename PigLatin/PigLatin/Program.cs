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
            foreach (var word in words)
            {
                var firstLetter = word[0];
                var editedWord = word.Substring(1, word.Length - 1);
                var newWord = editedWord + firstLetter + "ay ";
                newWords.Add(newWord);
            }

            foreach (var word in newWords)
            {
                Console.Write(word);
            }
        }
    }
}
