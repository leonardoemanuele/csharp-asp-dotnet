using System;
/*List*/
using System.Collections.Generic;
/*LINQ*/
using System.Linq;

namespace LINQCLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a List with List<type elements> = _new_ keyword 
            List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
            List<double> marathons = new List<double> { }; /*Object Initialization (empty list)*/

            //Adding an element to the end of the list
            citiesList.Add("New York City");
            marathons.Add(144.07);
            marathons.Add(143.12);

            //Removing an element, returns True if delete ele False
            citiesList.Remove("Dubai");
            bool removed = marathons.Remove(143.12);

            //Clear the entire list
            marathons.Clear();

            //Accessing an element with nameList[index]
            string myCity = citiesList[0];

            //Reassigning element
            citiesList[0] = "Stockholm";

            //Counting elements in the list using .Count
            int numberCities = citiesList.Count;

            //Adding a new range of element at the end of the list
            citiesList.AddRange(new string[] { "Cairo", "Johannesburg" });

            //Looking for an element if exist inside the list (BOOL) 
            bool hasNewDelhi = citiesList.Contains("Bologna");

            //Printing each element from a LIST
            foreach (string city in citiesList)
            {
                Console.WriteLine($"{city}");
            }
            Console.WriteLine("___________________");

            /*LINQ collection query from a List*/
            var filterdCities = from c in citiesList
                               where c.Contains("b")
                               select c;

            //Printing the length using .Count()
            Console.WriteLine($"\nThe length is: {filterdCities.Count()}"); ;

            //Printing each element from a LINQ
            foreach (string city in filterdCities)
            {
                Console.WriteLine($"\n{city}");
            }

            

            //Applying a LINQ method .Where()
            var shortCity = citiesList.Where(c => c.Length < 4);





        }
    }
}
