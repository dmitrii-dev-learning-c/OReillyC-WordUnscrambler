using System;
using System.Collections.Generic;
using System.Linq;
using WordUnscrabler.WordUnscramblerData;
using WordUnscrabler.WordUnscramblerWorkers;


namespace WordUnscrabler
{
    class Program
    {

        //used for word unscrambler
        private const string wordListFileName = "wordlist.txt";
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();

        static void Main(string[] args)
        {
            Console.WriteLine("List Example Output: ");
            loopsandarrays_example.ListsAndArrays.ListExample();

            Console.WriteLine("Array Example Output: ");
            loopsandarrays_example.ListsAndArrays.ArrayExample();


            Console.WriteLine("Loop Example Output: ");
            loopsandarrays_example.LoopsExample.RunAllExamples();

            Console.WriteLine("Struct Example Output: ");
            struct_example.StructRuner.Run();

            Console.WriteLine("Null Coalescing Example Output: ");
            nullcolescing_example.NullCoalescingExample.Run();

            Console.WriteLine("File Read/Write Example Output: ");
            readwritefiles_example.ReadWriteFilesExample.Run();


            Console.WriteLine("\n");
            Console.WriteLine("Welcome to the Word Unscrambler!");

            bool continueWordUnscramble = true;

            do
            {
                Console.WriteLine("Please enter the option - F for file and M for Manual:");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name: ");
                        ExecuteScrambledWordsInFileScenario();
                        break;

                    case "M":
                        Console.Write("Enter scrambled words manually: ");
                        ExecuteScrambledWordsManuallyScenario();
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please enter 'F' for file or 'M' for manual input.");
                        break;
                }
                var ContinueDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue? Y/N");
                    ContinueDecision = (Console.ReadLine() ?? string.Empty);

                } while (!ContinueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                !ContinueDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordUnscramble = ContinueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

        private static void ExecuteScrambledWordsManuallyScenario()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = manualInput.Split(',');
            DisplayMatchedUnscrambledWords(scrambledWords);
        }
              
        private static void ExecuteScrambledWordsInFileScenario()
        {
            var fileName = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = _fileReader.Read(fileName);
            DisplayMatchedUnscrambledWords(scrambledWords);
        }


        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            string[] wordList = _fileReader.Read(wordListFileName);

            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            if (matchedWords.Any())
            {
                foreach(var matchedWord in matchedWords)
                {
                    Console.WriteLine("Match found for {0}: {1}", matchedWord.ScrambledWord, matchedWord.Word);
                }
            }
            else
            {
                Console.WriteLine("No matches found for the given scrambled words.");
            }
        }
    }
}
