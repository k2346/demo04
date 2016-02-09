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


            {
                dad.ToString();
            }
        }
    }
}
