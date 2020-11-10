using System;
using System.Collections.Generic;
using System.Text;

namespace Project2.Hangman
{
   public  class ModeChoice
   {
       public static string DisplayHangmanMenu()    
       {
            string password = "";
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.WriteLine("*                                    *");
            Console.WriteLine("*            JEU DU PENDU            *");
            Console.WriteLine("*                                    *");
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.WriteLine("*                **                  *");
            Console.WriteLine("*    1. DUO      **    2. SOLO       *");
            Console.WriteLine("*                **                  *");
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");


            string player = Console.ReadLine();

            Console.Clear();

            if (player == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
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
            }
            else if (player == "2")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                password = RandomPendu.RandomPendus();
            }
            else
            {
                Console.WriteLine("Veuillez choisir une valeur 1, pour le Pendu ou 2, pour le Morpion.");
                player = Console.ReadLine();
            }
            return password;
       }
   }
}
    
