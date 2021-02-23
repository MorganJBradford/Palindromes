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
      Array.Reverse(letters);
      string reverseWord = new string (letters);

      Palindrome userPalindrome = new Palindrome(word, reverseWord);
      Console.WriteLine(userPalindrome.CheckPalindrome());
    }
  }
}