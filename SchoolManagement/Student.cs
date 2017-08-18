using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement
{
    public class Student:Human
    {
        private int idClassNumber;

        public Student(string name,int idClassNumber) : base(name)
        {
            this.idClassNumber = idClassNumber;
        }

        public int IdClassNumber
        {
            get
            {
                return idClassNumber;
            }

            set
            {
                idClassNumber = value;
            }
        }

        public override string ToString()
        {
            Console.WriteLine("-------------HOC SINH-------------");
            return string.Format("{0} - Class: {1}", this.Name, this.IdClassNumber);
        }
    }
}