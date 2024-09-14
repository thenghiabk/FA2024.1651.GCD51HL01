using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_ClassDiagram_Aggregation
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }

    public class University
    {
        private List<Student> _students;

        public University()
        {
            _students = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            _students.Add(student);
        }

        public void PrintStudentList()
        {
            foreach (var student in _students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            University myUniversity = new University();

            Student student1 = new Student("John");
            Student student2 = new Student("Jane");

            myUniversity.EnrollStudent(student1);
            myUniversity.EnrollStudent(student2);

            myUniversity.PrintStudentList(); // John, Jane

            // Even if the university is destroyed, the students still exist
            myUniversity = null;

            Console.WriteLine(student1.Name); // John
            Console.WriteLine(student2.Name); // Jane
        }
    }
}
