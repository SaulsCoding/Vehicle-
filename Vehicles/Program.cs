using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {

            Car honda = new Car(1996,"Dragon", 25);
            string displayMake = honda.GetMake();
            Console.WriteLine(honda.Speed);
            honda.DriveFaster(50);
            Console.WriteLine(displayMake);
            Console.WriteLine(honda.Speed);
        }
    }
}
