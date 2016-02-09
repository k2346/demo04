using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt7
{
    class Dad : person
    {
         public int Money { get; set; }

        public Dad()
        {
        }

        public Dad(string name, int age, string address, int money) 
            : base(name,age,address)
        {
            Money = money;
        }
        public void DadMethod()
        {
            Console.WriteLine("*Spanking*");
        }

        // ylikirjoitetaan person luokassa oleva ToString metodi, jotta saadaan tulostuslauseeseen lisättyä dad luokan tiedot
        public override string ToString()
        {
            return base.ToString() + " Money: " + Money;
        }
    }
}
