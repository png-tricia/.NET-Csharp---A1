using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1PatriciaGariando
{
    public class GraduateStudent : Student
    {
        /* PROPERTIES */
        public string Program { get; set; }

        /* CONSTRUCTOR */
        public GraduateStudent(int id, string name, int age, string program) : base(id, name, age)
        {
            Program = program;
        }
    }
}
