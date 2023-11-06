using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter a word : ");

                string word = Console.ReadLine();
                string reverse = "";
 
                for (int i = word.Length -1 ; i>=0 ; i--)
                {
                    reverse += word[i];
                }

                if (reverse == word) { Console.WriteLine("Your word is a palindrome"); }
                else { Console.WriteLine("Your word is not a palindrome"); }
            
        }
    }
}