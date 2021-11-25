using System;

namespace MyApps
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Add("Go to gym");

            PasswordManager pm = new PasswordManager("iluvpie", false);

            //Calling Display() on both types
            //tdl.Display();
            //pm.Display();

            //Calling Reset()
            //tdl.Reset();
            //pm.Reset();

            tdl.Display();
            pm.Display();
        }
    }
}
