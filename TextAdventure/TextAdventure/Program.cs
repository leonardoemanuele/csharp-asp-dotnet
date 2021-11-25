using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            //USERinput1
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            Console.WriteLine("Type YES or NO:");
            string userIn = Console.ReadLine().ToUpper();
            while(userIn != "YES" && userIn != "NO")
            {
                switch (userIn)
                {
                    default:
                        Console.WriteLine("Please, Type YES or NO to continue...");

                        userIn = Console.ReadLine().ToUpper();
                        break;

                }
            

            }
            if (userIn == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!\nTHE END.");
            }

            if (userIn == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light \ncoming from under a door down the hall.\nYou walk towards it. Do you open it or knock ? ");
                //USERinput2
                Console.WriteLine("Type OPEN or KNOCK:");
                string userIn2 = Console.ReadLine().ToUpper();
                while (userIn2 != "KNOCK" && userIn2 != "OPEN")
                {
                    switch (userIn2)
                    {
                        default:
                            Console.WriteLine("Please, Type KNOCK or OPEN to continue...");

                            userIn2 = Console.ReadLine().ToUpper();
                            break;

                    }
                    break;


                }

                if(userIn2 == "KNOCK")
                {
                    //RIDDLE1
                    Console.WriteLine("... ?!?! ... ");
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\"\n\"Poor people have it. Rich people need it. \nIf you eat it you die. What is it?");
                    //USERInput3 - Riddle1
                    Console.WriteLine("Type your answer, you have 5 attempts:");
                    string riddleAnswer = Console.ReadLine().ToUpper();

                    int i = 3;
                    while (riddleAnswer != "NOTHING")
                    {
                        Console.WriteLine($"Wrong Answer... {i+1} remained");
                        Console.WriteLine("Type again your answer:");
                        riddleAnswer = Console.ReadLine().ToUpper();
                        i--;

                        if (riddleAnswer == "NOTHING")
                        {
                            Console.WriteLine($"The door opens and {riddleAnswer} is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.");
                            break;

                        }
                        else if (i == 0)
                        {
                            Console.WriteLine("The door doesn't open. You  have the last attempt...");
                            
                            
                        }
                        else if(i < 0)
                        {
                            Console.WriteLine("You answered incorrectly for 5 times. The door doesn't open.\nTHE END.");
                            break;
                        }
                    }

                }

                if(userIn2 == "OPEN")
                {
                    Console.WriteLine("The door is locked! ... ");
                    Console.WriteLine("... ! ... ");
                    Console.WriteLine("See if one of your three keys will open it. You have 5 attempts");

                    //UserInputNumber
                    Console.WriteLine("Enter a number from 1 to 3 ");
                    string keyChoice = Console.ReadLine();
                    int j = 3;
                    while (keyChoice != "1" || keyChoice != "2" || keyChoice != "3")
                    {
                        Console.WriteLine($"This is not the right key... {j+1} remained");
                        Console.WriteLine("Enter a number from 1 to 3");
                        keyChoice = Console.ReadLine();
                        j--;

                        if (keyChoice == "1")
                        {
                            Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there.Strange...\nTHE END.");
                            break;
                        }
                        else if (keyChoice == "2")
                        {
                            Console.WriteLine("You choose the second key. The door does not open.\nTHE END.");
                            break;

                        }
                        else if (keyChoice == "3")
                        {
                            Console.WriteLine("You choose the third key. The door does not open.\nTHE END.");
                            break;
                        }
                        else if (j == 0)
                        {
                            Console.WriteLine("You have the last attempt remained...");
                            
                        }
                        else if (j < 0)
                        {
                            Console.WriteLine("You answered incorrectly for 5 times. The door doesn't open.\nTHE END.");
                            break;
                        }




                    }







                }





             }
               
                
                


        }
                
               


    }

            
           


            
           






}


