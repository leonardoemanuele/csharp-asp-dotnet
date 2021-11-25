using System;
namespace References
{
    class Book : IFlippable
    {
        //Interface Members
        public int CurrentPage
        { get; set; }
        public void Flip()
        {
            CurrentPage++;
        }


        //ClassMembers
        public string Author { get; set; }
        public string Title { get; set; }

        public Book(string author = "Unknown", string title = "No-Title")
        {
            Author = author;
            Title = title;
        }

        public virtual string Stringify()
        {
            return "This is a book object!";
        }

        


    }
}
