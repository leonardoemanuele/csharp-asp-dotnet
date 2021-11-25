using System;

namespace ClassForest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Forest f = new Forest();
            
            //Accessing Public Members Property
            /*
            f.Name = "Amazon";
            f.Biome = "Desert";
            */
            /*
      
            f.Age = 50000000;

            Will cause an error because the Property Age,
            can be accessed only within the class Forest, as it has the set method to PRIVATE

            Although we left the *field age PUBLIC for comparing purpose,
            so we can access directly the field from outside without any errors!

            f.age = 55000000; 

            */

            Forest f2 = new Forest("Congo", "Tropical");

            Console.WriteLine(f2.Name);
            Console.WriteLine(f2.Biome);

            //Calling Static Method to print tree facts
            Forest.PrintTreeFacts();

            //Calling Static Property to show the number of instances of Forest class
            Console.WriteLine($"The number of instances created is: \n{Forest.ForestsCreated}");

            Forest f3 = new Forest("Amazon");
            //Calling again to show the number of instances created updated
            Console.WriteLine($"The number of instances created is: \n{Forest.ForestsCreated}");

        }
    }
}
