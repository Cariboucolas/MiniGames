using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Project2
{
    public class Mot
    {

        public static void mot()
        {
            string password = "";
            Console.Write("Entre un mot en français : ");
            ConsoleKeyInfo keyInfo;
            do
            {
               
                    keyInfo = Console.ReadKey(true);
               if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Spacebar)
                {
                    password += keyInfo.KeyChar;
                    Console.Write("*");
                }
            }
            while (keyInfo.Key != ConsoleKey.Enter);

            int longeurmot = password.Count();
            Console.Write("ton mot comporte {0} carateres", longeurmot);
            
                
           
        }
      
      
    }
}
