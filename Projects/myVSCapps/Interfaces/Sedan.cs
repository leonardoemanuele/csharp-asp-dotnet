using System;
namespace Interfaces_Inheritance.Properties
{
  class Sedan
  {
    //PROPERTIES

    public string LicensePlate
    {
      get;
    }
    public double Speed
    {
      get;
      private set;
    }
    public int Wheels
    {
      get;
    }

    //CONSTRUCTORS

    public Sedan(double speed)
    {
      Speed = speed;
      LicensePlate = "00x00x00"; //Tools.GenerateLicensePlate() // Can be A Static Method or a Tool methods
      Wheels = 4;
    }

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
  }
}
