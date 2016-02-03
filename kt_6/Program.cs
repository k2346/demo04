using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //luo Kameran
            Kamerat kamerat = new Kamerat("Nikon", "Closet 1", "True", "D80", "18-135mm");
            Console.WriteLine("Camera = " + kamerat.ToString());
            kamerat.KameratLost();
           

            //luo ruoka
            Ruokia ruoka = new Ruokia("Banaani", "Closet 7", "False", "True");
            Console.WriteLine("Food = " + ruoka.ToString());

            //luo kirja
            Kirja kirja = new Kirja("Harry Potter ja Viisasten kivi", "Closet 2", "false", "J. K. Rowling");
            Console.WriteLine("Book = " + kirja.ToString());

        }
    }
}
