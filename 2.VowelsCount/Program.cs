using System;
using System.Linq;
namespace _2.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            SearchForVowels(input);
        }
        private static void SearchForVowels(string text)
        {
            int count = 0;
            //Console.WriteLine(text.Count(vowels => "aoeiu".Contains(vowels)));
            foreach (char vowle in text)
            {
                if ("aoeiu".Contains(vowle))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
