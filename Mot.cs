using System;
using System.Collections.Generic;
using System.Globalization;
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
                password += keyInfo.KeyChar;
                Console.Write("*");
            }
            while (keyInfo.Key != ConsoleKey.Enter);
        }
      
      
    }
}
