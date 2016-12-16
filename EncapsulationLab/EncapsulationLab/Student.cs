using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabs
{
    class Student : Person
    {
        public double GPA { get; set; }

        private ArrayList Grades { get; set; }


        public Student(string name, int ID) : base(name, ID)
        {
            this.GPA = 0;
            Grades = new ArrayList();
        }

        public Student(string name, int ID, int GPA): this(name, ID)
        { 
            this.GPA = GPA;
        }

        public void EnterGrade(double enteredGrade)
        {
            double sumOfGrades = 0;

            Grades.Add(enteredGrade);

            foreach (double grade in Grades)
            {
                sumOfGrades += grade;
            }

            GPA = sumOfGrades / (Grades.Count);
        }
    }
}
