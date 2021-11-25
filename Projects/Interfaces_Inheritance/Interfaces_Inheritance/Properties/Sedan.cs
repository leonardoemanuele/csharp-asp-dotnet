using System;
namespace Interfaces_Inheritance.Properties
{
    class Sedan : Vehicle, IAutomobile
    {
        //CONSTRUCTORS

        public Sedan(double speed = 0) : base(speed)
        {
            //Calling the Base Constructor : base(speed)[(with 1 param)] I dont need to have them code anymore

            /*
            this.Speed = speed;
            this.LicensePlate = "00x00x00"; //Tools.GenerateLicensePlate() // Can be A Static Method or a Tool methods
            */

            this.Wheels = 4;
        }


        //INHERIT from Vehicle, methods SpeedUp() and SlowDown()


        public override string Describe()
        {
            return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }
    }
}
