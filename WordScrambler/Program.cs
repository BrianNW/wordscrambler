using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScrambler
{
    class Program
    {
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
                var continueWordUnscrambleDecision = string.Empty;
                do
                {

                    Console.WriteLine("Do you want to continue? ");
                    continueWordUnscrambleDecision = (Console.ReadLine() ?? string.Empty);

                } while (
                        !continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                         !continueWordUnscrambleDecision.Equals("N")
                        );
                //if no, this will be false
                continueWordUnscramble = continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

            private static void ExecuteScrambledWordsManualEntryScenario()
            {
                throw new NotImplementedException();
            }

            private static void ExecuteScrambledWordsInFileScenario()
            {
                throw new NotImplementedException();
            }


        }
    }
}
