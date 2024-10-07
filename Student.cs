using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceExample_I_II
{
    internal class Student : Person // Exercise-II Part1-2
    {
        public Student(string name, string address) : base(name, address)
        {
            
        }
        public Student(string name, string address, int credit) : base(name, address)
        {
            Credit = credit;
        }

       public int Credit { get; set; }

        public int Credits()
        {
            return Credit;
        }

        public int Study()
        {
            return ++Credit;
        }

        public new string Show()
        {
            return Name + "\n\t" + Address + "\n\n" + "\tStudy credits " + Credit;
        }
    }
}
