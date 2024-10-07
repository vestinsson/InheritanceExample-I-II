using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample_I_II
{
    internal class Person // Exercise-II Part1-1
    {
        public Person() { }
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address {  get; set; }

        public string Show()
        {
            return Name + "\n\t" + Address + "\n\n";
        }

    }
}
