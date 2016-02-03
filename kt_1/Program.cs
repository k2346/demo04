using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //tehdään uusi radio ja asetetaan siihen arvoja
            Radio radio = new Radio();
            radio.OnOff = true;
            radio.Frequency = 15000.0;
            radio.Volume = 8;
            Console.WriteLine("Radio is on: {0}", radio.OnOff);
            Console.WriteLine("Radio Frequency is: " + radio.Frequency);
            Console.WriteLine("Radio volume is: " + radio.Volume);
            Console.WriteLine("");
           
            


            //tehdään toinen radio ja asetetaan siihen arvoja
            Radio radio1 = new Radio();
            radio1.OnOff = true;
            radio1.Frequency = 2155648415.0;
            radio1.Volume = -2;
            Console.WriteLine("Radio is on: {0}", radio1.OnOff);
            Console.WriteLine("Radio Frequency is: " + radio1.Frequency);
            Console.WriteLine("Radio volume is: " + radio1.Volume);
            Console.ReadLine();
        }
    }
}
