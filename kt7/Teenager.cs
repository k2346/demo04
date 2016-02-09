using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt7
{
    class Teenager : Dad
    {
        public int CoolLevel { get; set; }

        public Teenager()
        {
        }

        public Teenager(string name, int age, string address, int money, int coollevel) 
            : base(name,age,address, money)
        {
            CoolLevel = coollevel;
        }
        public void TeenagerMethod1()
        {
            Console.WriteLine("*Angst*");
        }

        public void TeenagerMethod2()
        { 
            Console.WriteLine("OOPS! Your teenager stole all of your money..");
        }
        // ylikirjoitetaan person luokassa oleva ToString metodi, jotta saadaan tulostuslauseeseen lisättyä dad ja teenager luokan tiedot
        public override string ToString()
        {
            return base.ToString() + " Cool level: " + CoolLevel;
        }
    }
}
