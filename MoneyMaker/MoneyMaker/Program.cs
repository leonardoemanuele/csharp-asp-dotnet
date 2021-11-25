using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            //Asking user for the amount to convert
            Console.WriteLine("Insert amount to converts in coins:");
            string user1 = Console.ReadLine();
            //Convert user input string into double
            double userAmount = Convert.ToDouble(user1);

            //Printing action on screen
            Console.WriteLine($"{userAmount} cents is equal to...");

            //Defining value of Silver and Gold Coins
            int goldValue = 10;
            int silverValue = 5;

            //Find the max number of Gold coins
            double goldCoins = Math.Floor(userAmount / goldValue);

            //Find the remainder of the Gold coins => Silver Coins 
            double remainder = userAmount % goldValue;

            //Find the max number of Silver coins
            double silverCoins = Math.Floor(remainder / silverValue);

            //Find the reminder of the Silver coins => Bronze Coins
            remainder = userAmount % silverValue;

            //Print the result
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");




        }
    }
}
