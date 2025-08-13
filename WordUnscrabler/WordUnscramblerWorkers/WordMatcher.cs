using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordUnscrabler.WordUnscramblerData;

namespace WordUnscrabler.WordUnscramblerWorkers
{
   public class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();

            foreach(var scrambledWord in scrambledWords)
            {
                foreach(var word in wordList)
                {
                    //characters and order of characters equal - then there was a match
                    if (scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                    }
                    else
                    {
                        var scrambledWordArray = scrambledWord.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambledWordArray);
                        Array.Sort(wordArray);

                        var sortedScrambledWord = new string(scrambledWordArray);
                        var sortedWord = new string(wordArray);

                        if(sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                        }

                    }
                }
            }

             MatchedWord BuildMatchedWord(string scrambledWord, string word)
            {
                MatchedWord matchedWord = new MatchedWord
                {
                    ScrambledWord = scrambledWord,
                    Word = word
                };
                return matchedWord;
            }

            return matchedWords;
        }

       
    }
}
