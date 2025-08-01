using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrabler.nullcolescing_example
{
    internal class NullCoalescingExample
    {

        public static void Run()
        {
            //if we set the person to be null we will get a runtime error
            Person person = null;
            //to avoid this error we can use the following operator ?? (called null coalescing operator)
            //Similar to a ternary operator but a little bit different instead of true false we check for null
            // if person is null then we return a default person.
            Person newPerson = person ?? new Person("Default", "Person");

            Console.WriteLine("First Name: " + newPerson.FirstName);
        }
    }
}
