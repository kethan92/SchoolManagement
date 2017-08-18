using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement
{
    public class School
    {
        // filed
        private List<Classes> classes=new List<Classes>();
        private string schoolName;

        public string SchoolName
        {
            get
            {
                return schoolName;
            }

            set
            {
                schoolName = value;
            }
        }

        internal List<Classes> Classes
        {
            get
            {
                return classes;
            }

            set
            {
                classes = value;
            }
        }



        // contructor

        public School(string schoolName)
        {
            this.schoolName = schoolName;
        
        }

        // add one class
       
        public override string ToString()
        {
            return string.Format("{0}", this.SchoolName + " Cac class: " + this.classes);
        }
    }
}