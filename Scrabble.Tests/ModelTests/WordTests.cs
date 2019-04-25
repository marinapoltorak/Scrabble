using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void ValueToMatch_WhatIsTheValueOfALetter_Number()
    {
      //Arrange
      Word newWord = new Word("a");

      //Act
      int result = newWord.ValueToMatch("a");

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}
