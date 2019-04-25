using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Word
  {

    private string _word;

    private static Dictionary<string, int> _instances = new Dictionary<string, int>() { {"a", 1}, {"e", 1}, {"i", 1}, {"o", 1}, {"u", 1}, {"l", 1}, {"n", 1}, {"r", 1}, {"s", 1}, {"t", 1}, {"d", 2}, {"g", 2}, {"b", 3}, {"c", 3}, {"m", 3}, {"p", 3}, {"f", 4}, {"h", 4}, {"v", 4}, {"w", 4}, {"y", 4}, {"k", 5}, {"j", 58}, {"x", 8}, {"q", 10}, {"z", 10} };

    public Word (string word)
    {
      _word = word;
      _instances.Add(this);
    }

    public string GetWord()
    {
      return _word;
    }

    public static Dictionary<Word> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static string ValueToMatch(string word)
    {
      char [] wordArray = word.ToCharArray();


    foreach (KeyValuePair<string, int> item in _instances)
    {
      Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
    }

    int total = 0;
    foreach (int value in _instances)
    {
      total = total + value;
    }

    _instances.Sum(x => x.Value);


    }
  }
}
