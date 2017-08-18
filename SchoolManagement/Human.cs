using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement
{
    public class Human
    {
        // filed
        private string name;
        private List<Comment> comment;


        // properties
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        // contructor
        public Human(string name)
        {
            this.name = name;
            comment = new List<Comment>();
        }
        // add one comment
      
    }
}