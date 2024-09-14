using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_ClassDiagram_Composition
{
    public class Engine
    {
        public void Start() { Console.WriteLine("Engine started!"); }
        public void Stop() { Console.WriteLine("Engine stopped!"); }

        public void Dispose() { Console.WriteLine("Engine has been destroyed!"); }
    }

    public class Car
    {
        private Engine _engine;

        public Car()
        {
            _engine = new Engine(); // Engine is created with the car
        }

        public void StartCar()
        {
            _engine.Start();
        }

        public void StopCar()
        {
            _engine.Stop();
        }

        ~Car()
        {
            _engine.Dispose(); // Engine is destroyed with the car
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.StartCar(); // Engine started!
            myCar.StopCar(); // Engine stopped!
            myCar = null;
        }
    }
}
