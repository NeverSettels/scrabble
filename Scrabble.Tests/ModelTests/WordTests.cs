using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.TestTools
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void Scrabble_GetScore_ScoresWorth1()
    {
      ScrabbleGame tester = new ScrabbleGame();
      int score = tester.GetScore("a e i o u l n r s t");
      Assert.AreEqual(score, 10);
    }
    [TestMethod]
    public void Scrabble_GetScore_ScoresWorth2()
    {
      ScrabbleGame tester = new ScrabbleGame();
      int score = tester.GetScore("dog");
      Assert.AreEqual(score, 5);
    }
    [TestMethod]
    public void Scrabble_GetScore_ScoresWorth3()
    {
      ScrabbleGame tester = new ScrabbleGame();
      int score = tester.GetScore("bcmp");
      Assert.AreEqual(score, 12);
    }
  }
}