using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;
        private double minGpa = 3.5;
        private bool completedAssignment = false;

        public Student(string name, string major, double gpa)
        {
            this.name = name;
            this.major = major;
            this.gpa = gpa;
        }

        public bool HasHonors() { 
            return this.gpa >= minGpa;
        }
    }
}
