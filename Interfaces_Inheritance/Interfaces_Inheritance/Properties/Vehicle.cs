using System;
namespace Interfaces_Inheritance.Properties
{
    abstract class Vehicle
    {
        //ABSTRACT MEMBER
        public abstract string Describe();


        //BASE CONSTRUCTOR
        public Vehicle(double speed)
        {
            this.Speed = speed;
            this.LicensePlate = "00x00x00";
        }


        //PROPERTIES protected: accessible by subclass
        public string LicensePlate
        { get; protected set; }

        public double Speed
        { get; protected set; }

        public int Wheels
        { get; protected set; }


        //METHODS
        virtual public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        virtual public void SpeedUp()
        {
            Speed += 5;
        }

        virtual public void SlowDown()
        {
            Speed -= 5;
        }
    }
}
