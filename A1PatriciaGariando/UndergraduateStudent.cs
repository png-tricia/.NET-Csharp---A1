using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1PatriciaGariando
{
    public class UndergraduateStudent : Student
    {
        /* PROPERTIES */
        public string Year { get; set; }

        /* CONSTRUCTOR */
        public UndergraduateStudent(int id, string name, int age, string year) : base(id, name, age)
        {
            Year = year;
        }
    }
}
