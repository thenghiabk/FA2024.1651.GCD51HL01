using System;
using System.Collections;

namespace AdvancedProgrammingExamples
{
    abstract class Person
    {
        // data
        private string name;
        private string address;
        private int age;

        //constructor
        public Person() { }
        public Person(string name) {
            this.Name = name;

        }
        public Person(string name, string address, int age) {
            this.Name = name;
            this.age = age;
            this.address = address;
        }


        // properties
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value < 0) // data validation
                {
                    throw new ArgumentOutOfRangeException();
                }

                age = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value.ToUpper();
            }
        }

        // methods
        public abstract void greets();
    }

    class UndergraduteStudent : Person
    {
        // data
        private int studentId;
        private string phone;
        private string subject;

        // properties
        public int StudentId
        {
            get { return studentId; }
            private set { studentId = value; }
        }        

        public string Phone {
            get { return phone; }
            set { phone = value; }        
        }

        public string Subject { get => subject; set => subject = value; }

        // constuctor
        public UndergraduteStudent() : base("Unknown")
        {

        }

        public UndergraduteStudent(string name) : base(name)
        {

        }
        // (1, "John", 22, "0123456789", "658 Ngo Quyen")
        public UndergraduteStudent(int id, string name, int age, string phone, string address, string subject)
            : base(name, address, age)
        {
            this.StudentId = id;
            this.Phone = phone;
            this.Subject = subject;
        }

        // methods
        public override void greets()
        {
            Console.WriteLine($"Hello. I'm {this.Name}. I'm an undergraduate student.");
        }
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
        // (2, "David", 30, "0123789456", "658 Ngo Quyen", "IoT")
        public GraduateStudent(int id, string name, int age, string phone, string address, string subject, string researchTopic ) 
            : base(id, name, age, phone, address, subject)
        {
            this.ResearchTopic = researchTopic;
        }

        // methods
        public override void greets()
        {
            Console.WriteLine($"Hello guys. I'm {this.Name}. I'm a graduate student.");
        }

    }

    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //Person person = new Person(); // error due to abstract class

            UndergraduteStudent student1 = new UndergraduteStudent(1, "John", 22, "0123456789", "658 Ngo Quyen", "Math");

            GraduateStudent student2 = new GraduateStudent(2, "David", 30, "0123789456", "658 Ngo Quyen", "English", "IoT");

            student1.greets();

            student2.greets();


            /*Console.WriteLine(student1.StudentId);
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Age);
            Console.WriteLine(student1.Phone);
            Console.WriteLine(student1.Address);
            Console.WriteLine(student1.Subject);

            Console.WriteLine(student2.StudentId);
            Console.WriteLine(student2.Name);
            Console.WriteLine(student2.Age);
            Console.WriteLine(student2.Phone);
            Console.WriteLine(student2.Address);
            Console.WriteLine(student2.Subject);
            Console.WriteLine(student2.ResearchTopic);*/

        }
    }
}
