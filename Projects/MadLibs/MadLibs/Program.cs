using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program ...
            Author: ...
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Mad Libs is starting...");


            // Give the Mad Lib a title:
            string title = "Title: Today Was A Good Day!";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();

            //Storing User defined Adjectives
            Console.WriteLine("Enter first adjective");
            string adj1 = Console.ReadLine();
            Console.WriteLine("Enter second adjective");
            string adj2 = Console.ReadLine();
            Console.WriteLine("Enter third adjective");
            string adj3 = Console.ReadLine();

            //Storing User defined Verbs
            Console.WriteLine("Enter verb");
            string verb = Console.ReadLine();

            //Storing User defined Nouns
            Console.WriteLine("Enter first noun");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Enter second noun");
            string noun2 = Console.ReadLine();

            //Ask User to define each of one
            Console.WriteLine("Enter an Animal");
            string animal = Console.ReadLine();
            Console.WriteLine("Enter a food");
            string food = Console.ReadLine();
            Console.WriteLine("Enter a fruit");
            string fruit = Console.ReadLine();
            Console.WriteLine("Enter a Superhero");
            string superhero = Console.ReadLine();
            Console.WriteLine("Enter a Country");
            string country = Console.ReadLine();
            Console.WriteLine("Enter a Dessert");
            string dessert = Console.ReadLine();
            Console.WriteLine("Enter a Year");
            string year = Console.ReadLine();




            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside," +
                $"\na bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to" +
                $"\nthe rhythm of the {noun1}, which made all the {fruit}s very {adj3}. \n " +
                $"\nConcerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name}" +
                $"\nin a puddle of frozen {dessert}. {name} woke up in the year {year}," +
                $"\nin a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

        }
    }
}