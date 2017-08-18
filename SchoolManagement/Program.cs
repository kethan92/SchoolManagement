using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[]
            {
                new Student("Ronaldo",1),
                new Student("Messi",1),
                new Student("Rivaldo",1),
                new Student("Caslos",1)
            };
            Teacher[] teacher = new Teacher[]
            {
                new Teacher("Kaka"),
                new Teacher("Rooney")
            };
            Classes classe = new Classes(1);
            classe.addStudents(student);
            Console.WriteLine(classe);
            foreach(var s in student)
            {
                Console.WriteLine(s);
            }
            
            Console.ReadKey();
        }

    }
}
