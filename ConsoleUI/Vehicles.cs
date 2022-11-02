using System;
namespace ConsoleUI
{
    public abstract class Vehicles
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Unique Make";
        public string Model { get; set; } = "Unique Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} is virtually in drive");
        }
    }
}

