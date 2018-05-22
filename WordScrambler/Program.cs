using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScrambler.Data;
using WordScrambler.Workers;

namespace WordScrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        private const string wordListFileName = "wordlist.txt";

        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;
            do
            {
                Console.WriteLine("Please enter the option - F for File and M for Manual");
                //null coalescing. If input is nothing, leave as empty string.
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name: ");
                        ExecuteScrambledWordsInFileScenario();
                        break;
                    case "M":
                        Console.Write("Enter Scrambled words manually: ");
                        ExecuteScrambledWordsManualEntryScenario();
                        break;
                    default:
                        Console.Write("Option was not recognized");
                        break;
                }
                var continueDecision = string.Empty;
                do
                {

                    Console.WriteLine("Do you want to continue? ");
                    continueDecision = (Console.ReadLine() ?? string.Empty);

                } while (
                        !continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                        !continueDecision.Equals("N")
                        );
                //if no, this will be false
                continueWordUnscramble = continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

            private static void ExecuteScrambledWordsManualEntryScenario()
            {
                var manualInput = Console.ReadLine() ?? string.Empty;
                string[] scrambleWords = manualInput.Split(',');
                DisplayMatchedUnscrambledWords(scrambleWords);

            }

            private static void ExecuteScrambledWordsInFileScenario()
            {
                var filename = Console.ReadLine() ?? string.Empty;
                string[] scrambledWords = _fileReader.Read(filename);
                DisplayMatchedUnscrambledWords(scrambledWords);
             }

            private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
            {
                 string[] wordList = _fileReader.Read(wordListFileName);

                 List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

                 if(matchedWords.Any())
                  {
                    foreach (var matchedWord in matchedWords)
                    {
                        Console.WriteLine("Match found for {0}: {1}", matchedWord.ScrambledWord, matchedWord.Word);
                    }
                  }
                    else
                          {
                              Console.WriteLine("No matches have been found.");
                          }
                    }
        
    }
}
