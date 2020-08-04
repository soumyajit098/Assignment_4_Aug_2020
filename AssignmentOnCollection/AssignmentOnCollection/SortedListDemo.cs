using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList myList = new SortedList();

            myList.Add("01", "First");
            myList.Add("03", "Third");
            myList.Add("05", "Fifth");
            myList.Add("04", "Fourth");
            myList.Add("02", "Second");

            foreach (DictionaryEntry item in myList)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }


            Console.WriteLine("------------Adding a key-value in SortedList------------");
            if (myList.ContainsValue("Sixth") == true)
            {
                Console.WriteLine("This value is already in the list");
            }
            else
            {
                myList.Add("06", "Sixth");
            }

            foreach (DictionaryEntry item in myList)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            myList.RemoveAt(2);
            Console.WriteLine("-------------After Removing index-----------");
            foreach (DictionaryEntry item in myList)
            {
                Console.WriteLine("{0} : {1} ", item.Key, item.Value);
            }

            Console.WriteLine("-------------After ContainsKey--------------");

            if (myList.ContainsKey("07") == true)
            {
                Console.WriteLine("Key is found");
            }
            else
            {
                Console.WriteLine("Key is not found");
            }


        }
    }
}