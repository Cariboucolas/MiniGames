using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class DisplayMainMenu
    {

       public static void DisplayWelcomeAndChoice()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.WriteLine("*                                    *");
            Console.WriteLine("*     BIENVENUE SUR WILD GAME !!     *");
            Console.WriteLine("*                                    *");
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("      ```           ```              ");
            Console.WriteLine("   -//::/+:.     -//////:`    -/++/. ");
            Console.WriteLine("  :+.    `:+.   :/.    `/+.  -+-  /+ ");
            Console.WriteLine(" `+/  -/`  +/       :/  `+:  -+.  :+`");
            Console.WriteLine("  /-  :+`  /+       /+` `+/  -+.  :+`");
            Console.WriteLine("      :+`  /+  .+.  /+` `+/  `.`  :+`");
            Console.WriteLine("  `   :+`  /+  -+-  /+` `+/       :+`");
            Console.WriteLine("  +/  :+`  /+  .+-  /+` `+/  `.   :+`");
            Console.WriteLine("  +/  -+.  `.  -+.  :+.  .`  :+.  // ");
            Console.WriteLine("  :+` `//-```.-+:   `//-````:+-      ");
            Console.WriteLine("  `//`  .:://:-`  ``  .:///:-`  `    ");
            Console.WriteLine("   `:+:        `-////-`      `.//`   ");
            Console.WriteLine("     ``    `:/+/:.  .-/+/::://:.     ");
            Console.WriteLine("            ``          ````         ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.WriteLine("*                                    *");
            Console.WriteLine("*          CHOISIS TON JEU :         *");
            Console.WriteLine("*         (Entrer une valeur)        *");
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.WriteLine("*                **                  *");
            Console.WriteLine("*    1. PENDU    **    2. MORPION    *");
            Console.WriteLine("*                **                  *");
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");   
        }
    }
}

