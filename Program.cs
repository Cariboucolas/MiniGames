using System;
using System.Linq;
using System.Collections.Generic;
using Project2;

internal class MainClass
{
    private class Program
    {
        private static Mot _word = new Mot();
        private static void Main(string[] args)
        {

            DisplayWelcome();
            DisplayLogo();
            DisplayChoiceMenu();
            int playerChoice = Convert.ToInt32(Console.ReadLine());

            if (playerChoice == 1)
            {
                _word.Run();
            }
            /*else if (playerChoice == 2)
            {
                GameChoiceTwo();
            }*/
            else
            {
                Console.WriteLine("Veuillez choisir une valeur 1, pour le Pendu ou 2, pour le Morpion.");
                playerChoice = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void DisplayWelcome() 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.WriteLine("*                                    *");
            Console.WriteLine("*     BIENVENUE SUR WILD GAME !!     *");
            Console.WriteLine("*                                    *");
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
        }

        static void DisplayChoiceMenu() 
        {
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

        static void DisplayLogo()
        {
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

            Console.WriteLine("\nTu possèdes actuellement :" + Life.GetLife() + " vie");
        }
    }
}

