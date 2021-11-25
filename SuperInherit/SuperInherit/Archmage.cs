using System;
namespace SuperInherit
{
    public class Archmage : Mage
    {
        public Archmage(string title):base(title)
        {
        }

        public override Storm CastRainStorm()
        {
            Storm s = new Storm("rain", true, this.Title);
            return s;
        }

        public Storm CastLightningStorm()
        {
            Storm s = new Storm("lightning", true, this.Title);
            return s;
        }
    }
}
