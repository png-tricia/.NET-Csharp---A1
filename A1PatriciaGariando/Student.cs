using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1PatriciaGariando
{
    public class Student
    {
        /* PROPERTIES */
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Dictionary as a Property 
        public Dictionary<string, int> Grades { get; set; }

        /* CONSTRUCTOR */
        public Student(int id, string name, int age)
        {
            StudentId = id;
            Name = name;
            Age = age;
            Grades = new Dictionary<string, int>(); // instantiate 
        }

        /* METHOD(S) */
        public double GetGPA()
        {
            double gpaTotal = 0;
            double gpaFinal = 0;

            // we want to loop through the values in our Grades dictionary to be able to calculate the GPA 
            foreach (var item in Grades.Values)
            {
                if (item < 60)
                {
                    gpaTotal += 0;
                }
                else if (item < 70)
                {
                    gpaTotal += 1;
                }
                else if (item < 80)
                {
                    gpaTotal += 2;
                }
                else if (item < 90)
                {
                    gpaTotal += 3;
                }
                else
                {
                    gpaTotal += 4;
                }
            }
            return gpaFinal = (gpaTotal / 3);
        }
    }
}
