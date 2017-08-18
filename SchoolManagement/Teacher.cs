using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement
{
    public class Teacher:Human
    {
        private Disciplines disciplines;

        public Teacher(string name, Disciplines disciplines) : base(name)
        {
            this.disciplines = disciplines;
        }

       
      

        public override string ToString()
        {
            Console.WriteLine("----------------TEACHER---------------");
            return string.Format("{0}- D")
        }

    }
}