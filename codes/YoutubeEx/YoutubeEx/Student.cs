using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeEx
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor,double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;

        }

        //creating method, checking ıf the student has honors 
        public bool HasHonor()
        {
            if (gpa >= 2.5)
            { 
                return true;
            }
            return false;

        }
    }
}
