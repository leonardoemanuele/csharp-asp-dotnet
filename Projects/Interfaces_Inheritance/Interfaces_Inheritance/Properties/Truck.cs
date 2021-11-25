using System;
namespace Interfaces_Inheritance.Properties
{
    class Truck : Vehicle, IAutomobile
    {
        //CONSTRUCTORS

        public Truck(double speed = 0, double weight = 0) : base(speed)
        {
           
            this.Weight = weight;
            this.Wheels = (this.Weight < 400) ? 8 : 12;

        }

        //PROPERTIES

        public double Weight { get; }

        //INHERITED from Vehicle

        public override string Describe()
        {
            return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

        /*
        public string LicensePlate
        { get; }

        public double Speed
        { get; private set; }

        public int Wheels
        { get; }

        //METHODS

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }
        */

    }
}
