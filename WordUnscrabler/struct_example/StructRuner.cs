using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrabler.struct_example
{
    internal class StructRuner
    {
        public static void Run()
        {
            // Create an instance of the struct
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";

            ChangeName(person);

            // Access the properties
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}");

            //Conclusion - struct is a value type so we still see John Smith


        }

        private static void ChangeName(Person personToChange)
        {
            personToChange.FirstName = "Jane";
            personToChange.LastName = "Doe";
        }
    }
}
