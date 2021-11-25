using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
           {
            /* Simple script of code that takes Lyrics and Censor swearing and bad words */

            string lyrics50Cent = "Now these pussy niggas putting money on my head \nGo on and get your refund motherfucker, I ain't dead";
            int length = lyrics50Cent.Length;

            int charPosition1 = lyrics50Cent.IndexOf("pussy");
            int charPosition2 = lyrics50Cent.IndexOf("niggas");
            int charPosition3 = lyrics50Cent.IndexOf("motherfucker");

            charPosition1++;
            charPosition2++;
            charPosition3++;

            int length1 = "pussy".Length;
            int length2 = "niggas".Length;
            int length3 = "motherfucker".Length;
            //Console.WriteLine(length1);

            length1 -= 2;
            length2 -= 2;
            length3 -= 2;


            //Take Words to Censor Lyrics
            string censorWord1 = lyrics50Cent.Substring(charPosition1, length1);
            string censorWord2 = lyrics50Cent.Substring(charPosition2, length2);
            string censorWord3 = lyrics50Cent.Substring(charPosition3, length3);

            //Create New Clean Lyrics replacing the Censor Words with XXX
            string NewCleanLyrics = lyrics50Cent.Replace(censorWord1, "XXX");
            NewCleanLyrics = NewCleanLyrics.Replace(censorWord2, "XXX");
            NewCleanLyrics = NewCleanLyrics.Replace(censorWord3, "XXX");


            Console.WriteLine(NewCleanLyrics);

        }
    }
}