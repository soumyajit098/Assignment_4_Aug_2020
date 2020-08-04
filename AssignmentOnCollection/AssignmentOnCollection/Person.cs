using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnCollection
{
    class Person
    {
        int age;
        string fname;
        string lname;
        string city;
        public Person()
        {

        }
        public Person(int _age, string _fname, string _lname, string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public void DisplayPerson()
        {
            Console.WriteLine("age:{0} firstname:{1} lastname:{2} city:{3}", age, fname, lname, city);
        }
        static void Main()
        {
            List<Person> PersonList = new List<Person>();
            PersonList.Add(new Person(22, "Soumyajit", "Pal", "Kolkata"));
            PersonList.Add(new Person(21, "Sayantan", "Chattarjee", "kolkata"));
            PersonList.Add(new Person(23, "Komal", "Rana", "HP"));
            PersonList.Add(new Person(20, "Dipanjan", "Das", "Kolkata"));
            PersonList.Add(new Person(25, "Subhajit", "Paul", "Hyderabad"));
            foreach (var p in PersonList)
            {
                Console.WriteLine("Person: {0},{1},{2},{3}", p.Age, p.Fname, p.Lname, p.City);
            }
            Console.Read();
        }
    }
}
