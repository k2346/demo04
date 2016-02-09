using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dad dad = new Dad();
            dad.Name = "Seppo Taalasmaa";
            dad.Age = 57;
            dad.Address = "Piippukatu 2 40100 Jkl";
            dad.Money = 894826001;

            Teenager teenager = new Teenager();
            teenager.Name = "Mirkkuli Taalasmaa";
            teenager.Age = 14;
            teenager.Address = dad.Address;
            teenager.Money = dad.Money;
            teenager.CoolLevel = 7;

            Console.WriteLine("Dad = " + dad.ToString());
            Console.WriteLine("Teenager = " + teenager.ToString());
            //  Console.WriteLine(teenager.TeenagerMethod2());
           // Console.WriteLine(dad.DadMethod());
            //Console.WriteLine(teenager.TeenagerMethod1());
            
           
        }
    }
}
