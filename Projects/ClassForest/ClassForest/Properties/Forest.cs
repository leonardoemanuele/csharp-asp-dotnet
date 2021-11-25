using System;
namespace ClassForest
{
    class Forest
    {
        //FIELDS

        public int age;
        private string biome;

        //STATIC

        private static string treeFacts;
        /*Defining a private static field member, for counting the total instances of the class*/
        private static int forestsCreated;



        //CONSTRUCTORS

        //First constructor
        public Forest(string name, string biome)
        {
            this.Name = name;
            this.Biome = biome;
            //increment static member *Property
            ForestsCreated++;

        }

        //Second constructor, avoiding copied code 
        public Forest(string name) : this(name, "Unknown")
        {
            Console.WriteLine($"As there's no biome for {name} forest,\ndefault biome has been set to \"unknown\"");
        }

        //STATIC
        static Forest()
        {
            treeFacts = "Forests provide a diversity of ecosystem services including:\r\n aiding in regulating climate.\r\n purifying water.\r\n mitigating natural hazards such as floods.\n";
        }



        //PROPERTIES

        //Memeber *Properties (Get Automatic fields)
        public string Name
        {
            get;
            set;
        }

        public int Trees
        {
            get;
            set;
        }

        //Member, Property Age, with public getter and private setter
        public int Age
        {
            get { return age; }
            //The age field can be accessed only within this class
            private set { age = value; }
        }

        //PUBLIC *Property to access the PRIVATE *field biome
        public string Biome
        {
            get { return biome; }
            set
            {
                switch (value)
                {
                    case "Tropical":
                        biome = value;
                        break;
                    case "Temperate":
                        biome = value;
                        break;
                    case "Boreal":
                        biome = value;
                        break;
                    default:
                        biome = "Unknown";
                        break;

                }
            }
        }

        //STATIC PROPERTIES

        /*Defining a public static Property, ForestsCreated, with public getter,
         * and private setter that increment static *field member */
        public static int ForestsCreated
        {
            get { return forestsCreated; }
            private set { forestsCreated = value; }
        }

        public static string TreeFacts
        {
            get { return treeFacts; }
        }



        //METHODS

        //STATIC

        /*Public Static Method*/
        public static void PrintTreeFacts()
        {
            Console.WriteLine(TreeFacts);
        }


        /*Increase the Area by growth*/
        public int Grow()
        {
            Trees += 30;
            Age += 1;

            return Trees;
        }

        /*Decrease the Trees number*/
        public int Burn()
        {
            Trees -= 20;
            Age += 1;

            return Trees;
        }
        

        
    }
}