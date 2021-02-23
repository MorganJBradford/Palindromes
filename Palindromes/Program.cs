using System;
using System.Collections.Generic;
using Palindromes.Models;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Palindrome Checker.");
      Console.WriteLine("Please enter a phrase, and we'll check if it is a palindrome for you:");
      string word = Console.ReadLine();
      char[] letters = word.ToCharArray();


      for (int i = 0; i < letters.Length / 2; i++)
      {
        char tmp = letters[i];
        letters[i] = letters[letters.Length - i - 1];
        letters[letters.Length - i - 1] = tmp;
      }

      string reverseWord = string.Join("", letters);
      Console.WriteLine(reverseWord);

      Palindrome userPalindrome = new Palindrome(word, reverseWord);
      Console.WriteLine(userPalindrome.CheckPalindrome());
    }
  }
}