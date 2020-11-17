using System;

namespace Project2
{
    public class DisplayBoardGame
    {
        public string joueur1 { get; set; }
        public string joueur2 { get; set; }

        public void DisplayBoardGames()
        {
            char[] boardGame = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

                


            Console.WriteLine("       -------------------------       ");
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       |   {0}   |   {1}   |   {2}   |       ", boardGame[0], boardGame[1], boardGame[2]);
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       -------------------------       ");
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       |   {0}   |   {1}   |   {2}   |       ", boardGame[3], boardGame[4], boardGame[5]);
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       -------------------------       ");
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       |   {0}   |   {1}   |   {2}   |       ", boardGame[6], boardGame[7], boardGame[8]);
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       -------------------------       ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

                

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }

        public void DisplayChooseName()
        {
            Console.Clear();
            DisplayMenuTicTacToe();

            Console.WriteLine("\nJoueur 1, entre ton nom :");
            Player player1 = new Player();
            player1.ChooseName();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nBienvenue : " + player1.PlayerName);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nJoueur 2, entre ton nom :");
            Player player2 = new Player();
            player2.ChooseName();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nBienvenue : " + player2.PlayerName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        public static void DisplayMenuTicTacToe()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.WriteLine("*                                    *");
            Console.WriteLine("*     BIENVENUE SUR LE MORPION !!    *");
            Console.WriteLine("*                                    *");
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
        }
        
    }
}
