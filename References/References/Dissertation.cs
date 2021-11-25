using System;
namespace References
{
    class Dissertation : Book, IFlippable
    {
        //Interface members
        public int CurrentPage { get; set; }
        public void Flip()
        {
            CurrentPage++;
        }



        public Dissertation(int page = 0)
        {
            CurrentPage = page;
        }
      

        //members
        public string Define()
        {
            return "dissertation - a long essay on a particular subject";
        }

        public override string Stringify()
        {
            return "This is a Dissertation object!";
        }
    }
}
