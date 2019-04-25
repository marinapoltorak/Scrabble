using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Program
  {
    public static void Main ()
    {
      Console.WriteLine("Enter a word: ");
      string inputtedWord = Console.ReadLine();

      string answer = Word.ValueToMatch(inputtedWord);
      Console.WriteLine("This is your number: " + answer);
      Word newWord = new Word(inputtedWord);

    }

  }

}
