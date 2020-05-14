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
  }
}