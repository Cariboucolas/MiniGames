using System;
using System.Collections.Generic;

namespace Project2
{
    internal class GameChooser
    {
        private IList<Game> _availableGames = new List<Game> { new HangmanGame(), new TicTacToeGame() };

        internal Game Choose()
        {
            Int32 playerChoice = Convert.ToInt32(Console.ReadLine());
            if (playerChoice > _availableGames.Count || playerChoice < 1)
            {
                Console.WriteLine("Veuillez choisir une valeur entre 1 et " + _availableGames.Count);
                return Choose();
            }
            else
            {
                return _availableGames[playerChoice - 1];
            }
        }

        public void DisplayMenu()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.WriteLine("*                                    *");
            Console.WriteLine("*     BIENVENUE SUR WILD GAME !!     *");
            Console.WriteLine("*                                    *");
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");

            Output.Draw("      ```           ```              \n" +
                        "   -//::/+:.     -//////:`    -/++/. \n" +
                        "  :+.    `:+.   :/.    `/+.  -+-  /+ \n" +
                        " `+/  -/`  +/       :/  `+:  -+.  :+`\n" +
                        "  /-  :+`  /+       /+` `+/  -+.  :+`\n" +
                        "      :+`  /+  .+.  /+` `+/  `.`  :+`\n" +
                        "  `   :+`  /+  -+-  /+` `+/       :+`\n" +
                        "  +/  :+`  /+  .+-  /+` `+/  `.   :+`\n" +
                        "  +/  -+.  `.  -+.  :+.  .`  :+.  // \n" +
                        "  :+` `//-```.-+:   `//-````:+-      \n" +
                        "  `//`  .:://:-`  ``  .:///:-`  `    \n" +
                        "   `:+:        `-////-`      `.//`   \n" +
                        "     ``    `:/+/:.  .-/+/::://:.     \n" +
                        "            ``          ````         \n",
                        ConsoleColor.DarkRed);

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