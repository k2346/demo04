﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt7
{
    class person
    {
        public string Name { get; set; }
        public string Address {get; set;}
        public int Age { get; set; }
        public void PersonMethod()
        {
            Console.WriteLine("Walking.. ->>");

        }
        public void PersonMethod2()
        {
            Console.WriteLine("Speaking nonsense");
        }
        public override string ToString() // palauttaa merkkijonon
        {
            return " Name: " + Name + " Age: " + Age + " Address: " + Address;
        }
    }
}
