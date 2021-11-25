using System;
namespace SuperInherit
{
    public class Pupil
    {
        public string Title { get; private set; }
        
        public Pupil(string title)
        {
            this.Title = title;
        }

        public Storm CastWindStorm()
        {
           Storm s = new Storm("wind", false, this.Title);
            return s;
        }
    }
}
