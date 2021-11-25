using System;

namespace SuperInherit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing the Storm Class
            Storm storm = new Storm("wind", false, "Merlin");
            storm.Announce();

            //Creating a new pupil Object
            Pupil pupil = new Pupil("Mezil-kree");

            //Pupil has a method that returns a Storm type, which we store 
            Storm stormOfPupil = pupil.CastWindStorm();

            //We use the inherited method Announce() from Storm
            stormOfPupil.Announce();

            //Creating a Mage class
            Mage mage = new Mage("Gul’dan");
            //Casting the inherited CastWindStorm() method
            Storm windStormOfMage = mage.CastWindStorm();
            //Calling the UNIQUE method of Mage class
            Storm rainStormOfMage = mage.CastRainStorm();
            windStormOfMage.Announce();
            rainStormOfMage.Announce();

            //Creating Archmage class
            Archmage archmage = new Archmage("Siri");
            Storm windStormOfArch = archmage.CastWindStorm();
            Storm rainStormOfArch = archmage.CastRainStorm();
            Storm lightStorm = archmage.CastLightningStorm();

            lightStorm.Announce();
        }
    }
}
