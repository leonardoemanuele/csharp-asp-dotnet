using System;

namespace RoversControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            //Creating an array of objects type Rover
            Rover[] rov = { lunokhod, apollo, sojourner };

            //Calling DirectAll
            DirectAll(rov);



        }

        //Static method to call each object's method
        public static void DirectAll(Object[] rov)
        {
            foreach (Object r in rov)
            {
                Console.WriteLine(r.GetInfo());
                Console.WriteLine(r.Explore());
                Console.WriteLine(r.Collect());
            }
        }
    }
}
