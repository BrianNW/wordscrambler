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
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name: ");
                        break;
                    case "M":
                        Console.Write("Enter Scrambled words manually: ");
                        break;
                    default:
                        Console.Write("Option was not recognized");
                        break;
                }
                var continueWordUnscrambledDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue? Y/N");
                    continueWordUnscrambledDecision = (Console.ReadLine() ?? string.Empty);
                } while {
                    !continueWordUnscrambledDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
                    !continueWordUnscrambledDecision.Equals("N", StringComparison.OrdinalIgnoreCase));
                } while ();
            }
            private static void ExecuteScrambeWordsInFileScenario()
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
