using System;
using Palindrome.Library;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayWithPalindromes();
        }

        static void PlayWithPalindromes()
        {
            Console.WriteLine("Enter string to test for palindrome property.");
            string s = Console.ReadLine();

            Word word = new Word(s);

            if(word.IsPalindrome())
                Console.WriteLine("Yes \"" + s + "\" is a palindrome.");
            else
                Console.WriteLine("No, \"" + s + "\" is not a palindrome.");

        }
    }
}
