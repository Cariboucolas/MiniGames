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
            Output.Draw("**************************************\n" +
                        "**************************************\n" +
                        "*                                    *\n" +
                        "*     BIENVENUE SUR WILD GAME !!     *\n" +
                        "*                                    *\n" +
                        "**************************************\n" +
                        "**************************************\n",
                        ConsoleColor.White);


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

            Output.Draw("**************************************\n" +
                        "**************************************\n" +
                        "*                                    *\n" +
                        "*          CHOISIS TON JEU :         *\n" +
                        "*         (Entrer une valeur)        *\n" +
                        "**************************************\n" +
                        "**************************************\n" +
                        "*                **                  *\n" +
                        "*    1. PENDU    **    2. MORPION    *\n" +
                        "*                **                  *\n" +
                        "**************************************\n" +
                        "**************************************\n",
                        ConsoleColor.White);
        }
    }
}