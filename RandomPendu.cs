using System;

namespace Project2
{
    public class RandomPendu
    {
     

        public static string RandomPendus()
        {

            Random random = new Random();
            var langages = new[] { "mailys", "colas", "gabriel", "fabien", "tomate","banane","parapluie","patate","audrey" };
            var rndMember = langages[random.Next(langages.Length)];

            return rndMember;

            //Console.WriteLine(rndMember);

            //Console.Read();

        }


    }
}
