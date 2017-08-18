using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Classes
    {
        private List<Teacher> teacher;
        private List<Student> student;
        private List<Comment> comment;
        private int idClass;

        public List<Teacher> Teacher
        {
            get
            {
                return teacher;
            }

            set
            {
                teacher = value;
            }
        }

        public List<Student> Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }

        public int IdClass
        {
            get
            {
                return idClass;
            }

            set
            {
                idClass = value;
            }
        }

        internal List<Comment> Comment
        {
            get
            {
                return comment;
            }

            set
            {
                comment = value;
            }
        }

        public Classes(List<Teacher> teacher,List<Student> student,int idClass)
        {
            this.teacher = teacher;
            this.student = student;
            this.idClass = idClass;
            comment = new List<Comment>();
        }

        public Classes(int idClass)
        {
            this.idClass = idClass;
            comment = new List<Comment>();
            teacher = new List<Teacher>();
            student = new List<Student>();
        }
        // add one Student
        public void addStudent(Student student)
        {
            this.student.Add(student);
        }
        // add array Student
        public void addStudents(Student[] students)
        {
            foreach(Student s in students)
            {
                this.student.Add(s);
            }
        }
        // add one Teacher
        public void addTeacher(Teacher teacher)
        {
            this.teacher.Add(teacher);
        }
        // add array Teachers
        public void addTeachers(Teacher[] teachers)
        {
            foreach (Teacher s in teachers)
            {
                this.teacher.Add(s);
            }
        }
        // add one comment
        public void addComment(Comment comment)
        {
            this.comment.Add(comment);
        }
        public override string ToString()
        {
            Console.WriteLine("---------CLASS------------");
            return string.Format("Class: {0}",this.IdClass);
        }
    }
}
