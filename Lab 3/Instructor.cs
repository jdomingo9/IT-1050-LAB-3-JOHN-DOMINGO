using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Instructor
    {
        private string name;
        private string courseName;

        public Instructor(string name, string courseName)
        {
            this.name = name;
            this.courseName = courseName;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
            student.PrintStudentInfo();
        }

        public void PrintInstructorInfo()
        {
            System.Console.WriteLine("Instructor: " + this.name);
            System.Console.WriteLine("Course: " + this.courseName);
        }
    }
}
    
