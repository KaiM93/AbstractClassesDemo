using System;
namespace ConsoleUI
{
    public class Cars : Vehicles
    {
        public Cars()
        {
        }

        public bool HasTrunk { get; set; } = true;


        public override void DriveAbstract()
        {
            Console.WriteLine("This unique car is in drive");
        }
    }
}

