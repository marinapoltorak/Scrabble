using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTest
  {

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word();
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void ValueToMatch_WhatIsTheValueOfLetters_Number()
    {
      //Arrange
      Word newWord = new Word("test");

      //Act
      // string output = newWord.ValueToMatch();

      //Assert
      Assert.AreEqual (2, Word.ValueToMatch("apple"));
    }
  }
}
