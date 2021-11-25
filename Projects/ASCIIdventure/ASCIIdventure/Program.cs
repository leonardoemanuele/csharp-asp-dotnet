using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            //BuildACreature();
            //SwitchChase(1, 1, 1);
            RandomMode();
            
        }

        static void BuildACreature()
        {
            int headNum = TranslateToNumber("ghost");
            int bodyNum = TranslateToNumber("monster");
            int feetNum = TranslateToNumber("fish");
            SwitchChase(headNum, bodyNum, feetNum);
        }

        static void BuildACreature(string head, string body, string feet)
        {/*
            switch (head.ToUpper())
            {
                case "GHOST":
                    GhostHead();
                    break;
                case "MONSTER":
                    MonsterHead();
                    break;
                case "BUG":
                    BugHead();
                    break;
                default:
                    Console.WriteLine($"{head} HEAD NOT FOUND!");
                    break;
            }
            switch (body.ToUpper())
            {
                case "GHOST":
                    GhostBody();
                    break;
                case "MONSTER":
                    MonsterBody();
                    break;
                case "BUG":
                    BugBody();
                    break;
                default:
                    Console.WriteLine($"{body} BODY NOT FOUND!");
                    break;
            }
            switch (feet.ToUpper())
            {
                case "GHOST":
                    GhostFeet();
                    break;
                case "MONSTER":
                    MonsterFeet();
                    break;
                case "BUG":
                    BugFeet();
                    break;
                default:
                    Console.WriteLine($"{feet} FEET NOT FOUND!");
                    break;
            }
        */}

        static void RandomMode()
        {
            /*We’ll create an instance of the CLASS Random and a new Random object by adding the following line of code*/
            Random randomNumber = new Random();

            /*Next, we want to use the Random class’s Next() method to randomly 
             * pick a number between 1 and inclusive of 3.*
             * 
             * Since there are three things we want to randomly select, we’ll want to call the Next() method three times,
             * each time saving it to a new variable.*/

            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);

            SwitchChase(head, body, feet);




        }

        static void SwitchChase(int head, int body, int feet)
        {
            switch (head) {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    MonsterHead();
                    break;
                case 3:
                    BugHead();
                    break;
            }
            switch (body) {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    MonsterBody();
                    break;
                case 3:
                    BugBody();
                    break;
            }
            switch (feet) {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    MonsterFeet();
                    break;
                case 3:
                    BugFeet();
                    break;
            }
        }

        static int TranslateToNumber(string creature)
        {
            switch (creature.ToUpper())
            {
                case "GHOST":
                    return 1;
                    break;
                case "MONSTER":
                    return 2;
                    break;
                case "BUG":
                    return 3;
                    break;
                default:
                    //Console.WriteLine($"{creature} NOT FOUND!");
                    return 1;
            }
        }



static void GhostHead()
{
    Console.WriteLine("     ..-..");
    Console.WriteLine("    ( o o )");
    Console.WriteLine("    |  O  |");
}

static void GhostBody()
{
    Console.WriteLine("    |     |");
    Console.WriteLine("    |     |");
    Console.WriteLine("    |     |");
}

static void GhostFeet()
{
    Console.WriteLine("    |     |");
    Console.WriteLine("    |     |");
    Console.WriteLine("    '~~~~~'");
}

static void BugHead()
{
    Console.WriteLine("     /   \\");
    Console.WriteLine("     \\. ./");
    Console.WriteLine("    (o + o)");
}

static void BugBody()
{
    Console.WriteLine("  --|  |  |--");
    Console.WriteLine("  --|  |  |--");
    Console.WriteLine("  --|  |  |--");
}

static void BugFeet()
{
    Console.WriteLine("     v   v");
    Console.WriteLine("     *****");
}

static void MonsterHead()
{
    Console.WriteLine("     _____");
    Console.WriteLine(" .-,;='';_),-.");
    Console.WriteLine("  \\_\\(),()/_/");
    Console.WriteLine("　  (,___,)");
}

static void MonsterBody()
{
    Console.WriteLine("   ,-/`~`\\-,___");
    Console.WriteLine("  / /).:.('--._)");
    Console.WriteLine(" {_[ (_,_)");
}

static void MonsterFeet()
{
    Console.WriteLine("    |  Y  |");
    Console.WriteLine("   /   |   \\");
    Console.WriteLine("   \"\"\"\" \"\"\"\"");
}
  }
}