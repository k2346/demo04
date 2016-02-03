using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //luo opiskelija
            Student student = new Student("Kirsi", "Kernel", "Piippukatu 2", "K8922");
            Console.WriteLine("Student = " + student.ToString());
            student.StudentMethod();
            student.PersonMethod();

            //luo opettaja
            Teacher teacher = new Teacher("Teppo", "Terävä", "kielokuja 7", "D566");
            Console.WriteLine("Teacher = " + teacher.ToString());
            teacher.TeacherMethod();
            teacher.PersonMethod();

        }
    }
}
