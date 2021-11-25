using System;
namespace MyApps
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            if (Password != "")
            {
                if (Hidden == false)
                {
                    Console.WriteLine("********");
                }
                else
                {
                    Console.WriteLine($"Password is {Password}");
                }
            }
            
            
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
            Console.WriteLine("Password has been reset to empty string\n");
        }
    }
}
