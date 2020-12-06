using System;

namespace Project2
{
    public class RandomPendu
    {
     

        public static string RandomPendus()
        {

            Random random = new Random();
            var langages = new[] { "poutre", "pitou", "reculer", "chocolatine" };
            var rndMember = langages[random.Next(langages.Length)];

            return rndMember;

            //Console.WriteLine(rndMember);

            //Console.Read();

        }


    }
}
