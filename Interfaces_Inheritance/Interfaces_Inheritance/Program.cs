using System;
using Interfaces_Inheritance.Properties;

namespace Interfaces_Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Interfaces and Inheritance\n" +
                "We have 3 different types of class, (Sedan, Truck, Bicycle) that implement the same IAutomobile interface.\n");

            Console.WriteLine("Each instance of the class type, INHERIT from the same SuperClass, or BaseClass => Vehicle\n");


            Sedan s = new Sedan(60);
            s.SpeedUp();

            Truck t = new Truck(45, 500);
            t.SpeedUp();

            Bicycle b = new Bicycle(10);
            b.SpeedUp();

            Console.WriteLine(b.Describe());
            Console.WriteLine(t.Describe());
            Console.WriteLine(s.Describe());


            
         

        }
    }
}
