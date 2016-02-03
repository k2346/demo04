using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    //student periytyy person luokasta
    //student on aliluokka Person on yliluokka/kantaluokka
    //student saa kaikki person luokan ominaisuudet ja toiminnot
    // - riippuen suojamääreistä Private suojamääritykset eivät periydy, public ja protected periytyy
    class Student : Person
    {
        public string StudentID { get; set; }
        public Student()
        {
        }

        public Student(string firstname, string lastname, string address, string studentID)
            : base(firstname,lastname,address)
        {
            StudentID = studentID;

        }

        public void StudentMethod()
        {
            Console.WriteLine("Learning OOP!");
        }

        //ylikirjoitetaan person luokassa oleva ToString metodi, jotta saadaan siihen lisättyä myös opiskelija id
        public override string ToString()
        { //muut periytyy yliluokasta ja nyt lisätään siihen vielä studentID
            return base.ToString() + " " + StudentID;
        }
    }
}
