using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrabler.loopsandarrays_example
{
    internal class ListsAndArrays
    {
        //List example:
        public static void ListExample()
        {
            //List:
            List<int> myFirstList = new List<int>();

            Console.WriteLine("List Count: "+ myFirstList.Count());

            //Appending to a List:
            myFirstList.Add(1);
            myFirstList.Add(2);
            myFirstList.Add(3);

            Console.WriteLine("List Count: " + myFirstList.Count());
        }

        // Array:
        public static void ArrayExample()
        {
            //Array - must be of a fixed size:
            int[] myFirstArray = { 7, 8, 4, 5, 15};

            //List (dynamic sizing) -
            //its actually using an array under the hood, but it can grow and shrink dynamically:
            var mySecondList = new List<int>();
            mySecondList.Add(5);

            Console.WriteLine("Second List Item at Index 0: "+ mySecondList[0]);


            //Sorting an array:
            Array.Sort(myFirstArray);
          
        }
    }
}
