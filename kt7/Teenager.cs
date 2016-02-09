using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt7
{
    class Teenager : Dad
    {
        private bool Cool { get; set; } 
        private void TeenagerMethod1()
        {
            Console.WriteLine("*Angst*");
        }
        // ylikirjoitetaan person luokassa oleva ToString metodi, jotta saadaan tulostuslauseeseen lisättyä dad ja teenager luokan tiedot
        public override string ToString()
        {
            return base.ToString() + " Money: " + Money + " Cool: " + Cool;
        }
    }
}
