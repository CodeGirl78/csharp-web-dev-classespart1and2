using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public string Instructor { get; set; }
        public string CourseName { get; set; }
        public List<Student> Student { get; set; }

        public Course(string instructor, string name, List<Student> student)
        {
            Instructor = instructor;
            CourseName = name;
            Student = student;
        }
    }
}
