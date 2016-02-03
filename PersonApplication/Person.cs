using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public Person()
        {
        }

        public Person(string firstname, string lastname, string address) // alustaa olion ominaisuudet
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
          
        }

        public void PersonMethod()
        {
            Console.WriteLine("Person does something");
        }
        //palauttaa merkkijonon
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Address;
        }
    }

}
