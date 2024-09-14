using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_ClassDiagram_Association
{
    class Doctor
    {
        public string Name { get; private set; }
        public string Department { get; private set; }
        public Doctor(string name, string department)
        {
            Name = name;
            Department = department;
        }
        // methods
        public void CheckUp(Patient patient)
        {
            Console.WriteLine($"The doctor `{this.Name}` is checking up for the patient `{patient.Name}`");
        }
    }

    class Patient
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public Patient(string name, string address)
        {
            Name = name;
            Address = address;
        }
        // methods
        public void GoToCheckUp(Doctor doctor)
        {
            Console.WriteLine($"The patient `{this.Name}` is checked up by the doctor `{doctor.Name}`");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("John Doe", "Plastic Surgery");
            Patient patient = new Patient("Nancy", "658 Ngo Quyen");

            doctor.CheckUp(patient);

            patient.GoToCheckUp(doctor);
        }
    }
}
