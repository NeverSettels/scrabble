using System;

namespace Scrabble.Models
{
  public class ScrabbleGame
  {
    public int GetScore(string word)
    {
      word = word.ToLower();
      int score = 0;
      for (int i = 0; i < word.Length; i++)
      {
        if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'l' || word[i] == 'n' || word[i] == 'r' || word[i] == 's' || word[i] == 't')
        {
          score++;
        }
      }
      return score;
    }
  }
}