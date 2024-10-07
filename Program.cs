using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceExample_I_II
{
    internal class Program
    {
        public static void PrintPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name + "\n\t" + person.Address + "\n\n");
                if (person is Teacher teacher)
                {
                    Console.WriteLine("salary " + teacher.Salery + "euro/month\n\n");
                }
                else if (person is Student student)
                {
                    Console.WriteLine("Study credits " + student.Credit + "\n\n");
                }
            }
        }
        static void Main(string[] args)
        {
            // Part-1
            //A a = new A();
            //B b = new B();
            //C c = new C();

            //a.a();
            //b.b();
            //c.c();

            // Part-2
            //C c = new C();

            //c.a();
            //c.b();
            //c.c();

            // Part-1 Person
            //Person ada = new Person("Ada Lovelace", "24 Maddox St. London W1S 2QN");
            //Person esko = new Person("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki");
            //Console.WriteLine(ada.Show());
            //Console.WriteLine(esko.Show());

            // Part-2 Student
            //Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
            //Console.WriteLine(ollie.Show());
            //Console.WriteLine("Study credits " + ollie.Credits());
            //ollie.Study();
            //Console.WriteLine("Study credits " + ollie.Credits());

            // Part-3 Student's Show() Method(or Print() method)
            //Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
            //Console.WriteLine(ollie.Show());
            //ollie.Study();
            //Console.WriteLine(ollie.Show());

            // Part - 4: Teacher
            //Teacher ada = new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200);
            //Teacher esko = new Teacher("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki", 5400);
            //Console.WriteLine(ada.Show());
            //Console.WriteLine(esko.Show());
            //Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
            //int i = 0;
            //while (i < 25)
            //{
            //    ollie.Study();
            //    i = i + 1;
            //}
            //Console.WriteLine(ollie.Show());

            // Part-5: List all Persons
            //List<Person> persons = new List<Person>();

            //persons.Add(new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200));
            //persons.Add(new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028"));

            //PrintPersons(persons);
           

            Console.ReadKey();

        }
    }
}
