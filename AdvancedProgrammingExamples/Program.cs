using System;
using System.Collections;

namespace AdvancedProgrammingExamples
{
    
    class UndergraduteStudent
    {
        // data
        private string name;
        private int id;
        private string address;
        private int age;

        // properties
        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                age = value;
            }
        }
        public string Name { 
            get { return name; } 
            private set { name = value; }
        }

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        public string Address
        {
            get { return address; }
            set { 
                address = value.ToUpper(); 
            }
        }

        // constuctor
        public UndergraduteStudent()
        {
            this.name = "Unknown";
        }

        public UndergraduteStudent(string name)
        {
            this.name = name;
        }

        // methods
        
    }

    class GraduateStudent : UndergraduteStudent
    {
        // data
        private string researchTopic;

        // properties
        public string ResearchTopic
        {
            get { return researchTopic; } 
            private set { researchTopic = value; }
        }

        // constuctor
        public GraduateStudent() : base()
        {
            
        }

        public GraduateStudent(string name, string researchTopic) : base (name) // step 1
        {
            
           
            // step 2
            this.researchTopic = researchTopic;
        }

        // methods

    }

    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            UndergraduteStudent student1 = new UndergraduteStudent(1, "John", 22, "0123456789", "658 Ngo Quyen");
            GraduateStudent student2 = new GraduateStudent(2, "David", 30, "0123789456", "658 Ngo Quyen", "IoT");

            Console.WriteLine(student1.Id);
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Age);
            Console.WriteLine(student1.Phone);
            Console.WriteLine(student1.Address);

            Console.WriteLine(student1.Id);
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Age);
            Console.WriteLine(student1.Phone);
            Console.WriteLine(student1.Address);
            Console.WriteLine(student1.ResearchTopic);
            Console.WriteLine(student1.Deadline);

        }
    }
}
