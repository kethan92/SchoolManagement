using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Disciplines
    {
        // filed
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
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

        public int NumberOfLectures
        {
            get
            {
                return numberOfLectures;
            }

            set
            {
                numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return numberOfExercises;
            }

            set
            {
                numberOfExercises = value;
            }
        }
        // add one comment
        public void addComment(Comment comment)
        {
            this.comment.Add(comment);
        }
        // contructor
        public Disciplines(string name,int numberOfLectures, int numberOfExercises)
        {
            this.name = name;
            this.numberOfExercises = numberOfExercises;
            this.numberOfLectures = numberOfLectures;
            comment = new List<Comment>();
        }

    }
}
