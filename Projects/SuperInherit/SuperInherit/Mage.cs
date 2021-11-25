using System;
namespace SuperInherit
{
    public class Mage : Pupil
    {
        public Mage(string title): base(title)
        {
            //Inherit from Pupil
        }

        public virtual Storm CastRainStorm()
        {
            Storm s = new Storm("rain", false, Title);
            return s;
        }
    }
}
