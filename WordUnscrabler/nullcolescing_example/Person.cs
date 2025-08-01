using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrabler.nullcolescing_example
{
    class Person
    {

        public Person(string argFirstName, string argLastName)
        {
            FirstName = argFirstName;
            LastName = argLastName;
        }
        public string FirstName { get; }
        public string LastName { get; }
    }
}
