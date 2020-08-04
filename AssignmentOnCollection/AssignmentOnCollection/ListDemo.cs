using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnCollection
{
    class ListDemo
    {
        private static bool isEven(int i)
        {
            return ((i % 2) == 0);
        }
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(25);
            list.Add(32);
            list.Add(60);
            list.Add(87);
            list.Add(55);

            foreach (int a in list)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine(".......FindIndex method.........");
            int numberIndex = list.FindIndex(x => x == 87);
            Console.WriteLine("60 is at {0} index", numberIndex);

            Console.WriteLine(".......FindLastIndex............");
            //
            Console.WriteLine(".......FindAll............");

            Console.WriteLine("Even numbers by using FindAll in list are: ");
            List<int> Result = new List<int>(list.FindAll(isEven));

            foreach (int i in Result)
            {
                Console.WriteLine(i);
            }


            Console.Read();

        }
    }
}
