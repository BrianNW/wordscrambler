using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScrambler.Data;

namespace WordScrambler.Workers
{
    class WordMatcher
    {
        public static List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            var matchedWords = new List<MatchedWord>();

            foreach(var scrambledWord in scrambledWords)
            {

                foreach (var word in wordList)
                {
                    if (scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(scrambledWord, word));         
                    } else
                    {
                        var scrambedWordArray = scrambledWord.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambedWordArray);
                        Array.Sort(wordArray);

                        var sortedScrambledWord = new string(scrambedWordArray);
                        var sortedWord = new string(wordArray);

                        if(sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                        }
                    }
                }

            }

            return matchedWords;
        }

        private MatchedWord BuildMatchedWord(string scrambledWord, string word)
        {
            MatchedWord matchedWord = new MatchedWord
            {
                ScrambledWord = scrambledWord,
                Word = word
            };

            return matchedWord;
            
        }
    }
}
