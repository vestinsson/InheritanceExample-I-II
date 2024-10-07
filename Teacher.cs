using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample_I_II
{
    internal class Teacher : Person
    {
        public Teacher(string name, string address) : base(name, address)
        {
        }

        public Teacher(string name, string address, int salery) : base(name, address)
        {
            Salery = salery;
        }

        public int Salery { get; set; }

        public new string Show()
        {
            return Name + "\n\t" + Address + "\n\n" + "\tsalery " + Salery + " euro/month\n";
        }

    }
}
