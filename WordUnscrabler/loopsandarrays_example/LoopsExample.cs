using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrabler.loopsandarrays_example
{
    internal class LoopsExample
    {

        private static void ForloopExample()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            // For Loop Example:
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("For Loop Iteration: " + i);
            }

            //For loop with array:
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("Array For loop: "+ array[i]);
            }
        }

        private static void WhileLoopExample()
        {
            // While Loop Example:
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("While Loop Iteration: " + i);
                i++;
            }
        }

        private static void DoWhileLoopExample()
        {
            // Do-While Loop Example:
            int j = 0;
            do
            {
                Console.WriteLine("Do-While Loop Iteration: " + j);
                j++;
            } while (j < 10);
        }

        private static void ForeachLoopExample()
        {
            // Foreach Loop Example:
            List<string> myList = new List<string> { "apple", "banana", "cherry" };
            foreach (var item in myList)
            {
                Console.WriteLine("Foreach Loop Item: " + item);
            }

        }


        //run all of the examples:
        public static void RunAllExamples()
        {
            Console.WriteLine("For Loop Example:");
            ForloopExample();
            Console.WriteLine("\nWhile Loop Example:");
            WhileLoopExample();
            Console.WriteLine("\nDo-While Loop Example:");
            DoWhileLoopExample();
            Console.WriteLine("\nForeach Loop Example:");
            ForeachLoopExample();
        }
    }
}
