using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    public class RandomPendu
    {
     

        public static void RandomPendus()
        {

            Random random = new Random();
            var langages = new[] { "Java", "C#", "PHP", "SQL" };
            var rndMember = langages[random.Next(langages.Length)];

            Console.WriteLine(rndMember);

            Console.Read();

        }


    }
}
