using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace WordUnscrabler.readwritefiles_example
{
    internal class ReadWriteFilesExample
    {

        public static void Run()
        {
            string[] lines = { "this is the first line ", "this is the second line", "this is the third line" };

            //Write the lines to a file:
            File.WriteAllLines("MyFirstFile.txt", lines);

            //Read the lines from the file:
            string[] fileContents = File.ReadAllLines("MyFirstFile.txt");

            //reading the file contents at once may not be the best option for large files
            //so we can read the file line by line:
            foreach (string line in File.ReadLines("MyFirstFile.txt"))
            {
                Console.WriteLine(line);
            }

            //ReadLines and WriteAllLines close the file automatically after reading or writing,


        }
    }
}
