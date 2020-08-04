using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> myList = new LinkedList<String>();

            myList.AddLast("Good");
            myList.AddLast("Evening");
            myList.AddLast("Everyone");
            myList.AddLast("Let's");
            myList.AddLast("Start");

            Console.WriteLine("myList after doing AddLast..........");

            foreach (string str in myList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("..........Count Property...............");

            if(myList.Count>0)
                Console.WriteLine("The first node of myList is: {0} ",myList.First.Value);
            else
                Console.WriteLine("myList is EMPTY");

            Console.WriteLine("***************************");
            Console.WriteLine("Contains property to find if the element is in the list or not");
            if (myList.Contains("Everyone") == true)
            {
                Console.WriteLine("Element Found...!!");
            }
            else
            {
                Console.WriteLine("Element Not found...!!");
            }

            Console.WriteLine("***************************");

            string[] myArr = new string[5];   //string array
            myList.CopyTo(myArr, 0);
            Console.WriteLine("Display str after copying:");

            foreach (string str in myArr)
            {
                Console.WriteLine(str);
            }

            //Console.WriteLine("***************************");

            Console.WriteLine(".......TO CHECK THE EQUALS METHOD.........");

            LinkedList<string> myList2 = new LinkedList<string>();
            myList2 = myList;
            Console.WriteLine(myList2.Equals(myList));


































            Console.Read();
        }
    }
}
