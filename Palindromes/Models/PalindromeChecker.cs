namespace Palindromes.Models
{
  public class Palindrome
  { 
    public string Word {get; set;}
    public string ReversedWord {get; set;}

    public Palindrome(string word, string reversedWord)
    {
    Word = word;
    ReversedWord = reversedWord;
    }
    public string CheckPalindrome()
    {
      if (Word == ReversedWord)
      {
        return "Yes, your word is a palindrome!";
      }
      return "sorry, try again.";
    }
  }
}