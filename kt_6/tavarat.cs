using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_6
{
    class tavarat
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Broken { get; set; }

        public tavarat()
        {
        }

        public tavarat(string name, string location, string broken) // alustetaan tavarat olion ominaisuudet
        {
            Name = name;
            Location = location;
            Broken = broken;
        }

       
        public override string ToString() // palauttaa merkkijonon
        {
            return " Name: " + Name + " Location: " + Location + " Broken: " + Broken;
        }
    }
}

