using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Word
  {
    private string _word;

    public Dictionary<char, int> _scrabbleDictionary = new Dictionary<char, int>() { {'a', 1}, {'e', 1}, {'i', 1}, {'o', 1}, {'u', 1}, {'l', 1}, {'n', 1}, {'r', 1}, {'s', 1}, {'t', 1}, {'d', 2}, {'g', 2}, {'b', 3}, {'c', 3}, {'m', 3}, {'p', 3}, {'f', 4}, {'h', 4}, {'v', 4}, {'w', 4}, {'y', 4}, {'k', 5}, {'j', 58}, {'x', 8}, {'q', 10}, {'z', 10} };

    public Word (string word)
    {
      _word = word;
    }

    public int ValueToMatch(string word)
    {
      char [] wordArray = word.ToCharArray();

      int total = 0;

      foreach (char letter in wordArray)
      //whatever is at the first place: what are we looking for? what do we want to do something to?
      //whatever is at the second place: where is that first thing located at?
      {
        if (_scrabbleDictionary.ContainsKey(letter))
        {
          total = total + _scrabbleDictionary[letter];
        }
      }
      return total;
    }
  }
}




// for (int index=0; index < word.Length; index++)
// {
//   if (_scrabbleDictionary.ContainsKey(word))
//   {
//     total = total + _scrabbleDictionary[word];
//   }
// }
// return total;
