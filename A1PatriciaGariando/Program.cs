using ConsoleTables;

namespace A1PatriciaGariando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of all Students 
            List<Student> students = new List<Student>()
            {
                new UndergraduateStudent(101, "Patricia Gariando", 21, "Junior"),
                new UndergraduateStudent(102, "Squidward Tentacles", 22, "Senior"),
                new UndergraduateStudent(103, "SpongeBob Squarepants", 20, "Sophmore"),
                new UndergraduateStudent(104, "Patrick Star", 19, "Freshman"),
                new GraduateStudent(201, "Sandy Cheeks", 25, "Master's"),
                new GraduateStudent(202, "Squilliam Fancyson", 23, "PhD"),
                new GraduateStudent(203, "Plankton", 32, "PhD"),
                new GraduateStudent(204, "Eugene H. Krabs", 34, "Master's")
            };

            // Each student to have their own set of grades 
            students[0].Grades = new Dictionary<string, int> { { "Math:", 83 }, { "Eng:", 75 }, { "His:", 80 } };
            students[1].Grades = new Dictionary<string, int> { { "Math:", 86 }, { "Eng:", 89 }, { "His:", 95 } };
            students[2].Grades = new Dictionary<string, int> { { "Math:", 95 }, { "Eng:", 90 }, { "His:", 93 } };
            students[3].Grades = new Dictionary<string, int> { { "Math:", 67 }, { "Eng:", 73 }, { "His:", 66 } };
            students[4].Grades = new Dictionary<string, int> { { "Adv. Algo:", 92 }, { "Data Sci:", 90 }, { "Res. Sem:", 95 } };
            students[5].Grades = new Dictionary<string, int> { { "Adv. Algo:", 89 }, { "Data Sci:", 76 }, { "Res. Sem:", 84 } };
            students[6].Grades = new Dictionary<string, int> { { "Adv. Algo:", 87 }, { "Data Sci:", 83 }, { "Res. Sem:", 99 } };
            students[7].Grades = new Dictionary<string, int> { { "Adv. Algo:", 85 }, { "Data Sci:", 62 }, { "Res. Sem:", 66 } };

            // Display 3 Tables 
            var undergraduateTable = new ConsoleTable("Student ID", "Name", "Age", "Year", "Grades", "GPA");
            var graduateTable = new ConsoleTable("Student ID", "Name", "Age", "Program", "Grades", "GPA");
            var honoursTable = new ConsoleTable("Student ID", "Name", "GPA");

            foreach (var student in students)
            {
                if (student.StudentId >= 100 && student.StudentId < 200)
                {
                    // we want to cast student to the derived class: UndergraduateStudent so we can access Year
                    UndergraduateStudent underGradStud = (UndergraduateStudent)student;
                    undergraduateTable.AddRow(student.StudentId, student.Name, student.Age, underGradStud.Year, $"Math: {student.Grades["Math:"]}, Eng: {student.Grades["Eng:"]}, His: {student.Grades["His:"]}", $"{student.GetGPA():F2}");
                }
                if (student.StudentId >= 200 && student.StudentId < 300)
                {
                    // we want to cast student to the derived class: GraduateStudent so we can access Program 
                    GraduateStudent gradStud = (GraduateStudent)student;
                    graduateTable.AddRow(student.StudentId, student.Name, student.Age, gradStud.Program, $"Adv. Algo: {student.Grades["Adv. Algo:"]}, Data Sci: {student.Grades["Data Sci:"]}, Res. Sem: {student.Grades["Res. Sem:"]}", $"{student.GetGPA():F2}");
                }
                if (student.GetGPA() >= 3)
                {
                    honoursTable.AddRow(student.StudentId, student.Name, $"{student.GetGPA():F2}");
                }
            }

            Console.WriteLine("\n\nUNDERGRADUATE STUDENTS: \n");
            undergraduateTable.Write(Format.Minimal);

            Console.WriteLine("\n\nGRADUATE STUDENTS: \n");
            graduateTable.Write(Format.Minimal);

            Console.WriteLine("\n\nHONOUR ROLL - STUDENTS WITH A GPA GREATER THAN OR EQUAL TO 3.00: \n");
            honoursTable.Write(Format.Minimal);
        }
    }
}
