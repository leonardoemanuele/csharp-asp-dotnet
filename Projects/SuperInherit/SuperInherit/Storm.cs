using System;
namespace SuperInherit
{
    public class Storm
    {
        //Authomatic Fields Properties
        public string Essence { get; private set; }
        public bool IsStrong { get; private set; }
        public string Caster { get; private set; }



        public Storm(string essence, bool isstrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isstrong;
            this.Caster = caster;
        }

        public void Announce() {

            if (IsStrong)
            {
                Console.WriteLine($"{Caster} evocate a strong {Essence} storm!"); 
            }
            else
            {
                Console.WriteLine($"{Caster} evocate a weak {Essence} storm!");
            }
        }
    }
}
