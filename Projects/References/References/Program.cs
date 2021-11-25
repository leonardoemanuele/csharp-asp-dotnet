using System;

namespace References
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dissertation diss = new Dissertation(50);

            //Reference: diss1 is now a reference-type variable holding the location memory of diss object;
            
            Dissertation diss1 = diss;
            Console.WriteLine("diss1 is now a reference-type variable holding the location memory of diss object\n");


            //Reference to a different-type (IFlippable) -> (Dissertation)
            //
            IFlippable fdiss = diss;
            Console.WriteLine("fdiss is now a different reference-type variable (IFlippable) holding the location memory of diss object\n");

            //We create an object bk of type _Book_ 
            Book bk = new Book();
            
            /*We create an _object_reference_ bdiss of type _Book_ that has a reference as a _Dissertation_ type object! 
             _Book_ obj behaves as a _Dissertation_obj */
            Book bdiss = new Dissertation();
            

            Console.WriteLine(bk.Stringify());
            Console.WriteLine(bdiss.Stringify());
            

            Console.WriteLine("\nEven tho bk and bdiss are both BOOK TYPE, their behavior is different!");
            Console.WriteLine("\n_Dissertation_ override Stringify() method");

        }
    }
}
