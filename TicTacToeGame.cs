using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class TicTacToeGame : Game
    {
        public override String Name { get => "Tic-Tac-Toe"; }
        public override IEnumerable<Player> Players { get; set; } = new List<Player>();

        public override void Run()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.WriteLine("*                                    *");
            Console.WriteLine("*     BIENVENUE SUR LE MORPION !!    *");
            Console.WriteLine("*                                    *");
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");

            
            Player player1 = NewPlayer("X", 1, ConsoleColor.Red);
            Player player2 = NewPlayer("O", 2, ConsoleColor.Blue);

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

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
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            Console.ReadLine();
        }
        public Player NewPlayer(string symbol, int numero, ConsoleColor color )
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nJoueur " + numero + " , entre ton nom :");
            var player = new Player();
            player.PlayerName = Console.ReadLine();
            player.PlayerSymbol = symbol;
            Console.ForegroundColor = color;
            Console.WriteLine("\nBienvenue : " + player.PlayerName + " ton symbole est : " + player.PlayerSymbol);

            return player;
        }
        public void CheckingSymbol()
        {

            
           /* char symbol;
            char symbolX = Convert.ToChar(88);
            char symbolO = Convert.ToChar(79);
            bool win = false;
            bool compare = false;*/
          

           /* while (win != true)
            {
                if (symbol == player1.symbol)
                {

                    compare = false;
                    while (compare != true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("       A toi de jouer " + player1.Nom);
                        string choice = Console.ReadLine();
                        int value = Convert.ToInt32(choice);
                        DisplayBoardGame boardGame = new DisplayBoardGame();
                        if (boardGame.DisplayBoardGames() == symbolX || boardGame[value] == symbolO)
                        {
                            Console.WriteLine(" Impossible case déjà prise Rejouer ");


                        }
                        else
                        {
                            symbol = player1.Symbole;
                            string Nomjoueur = player1.Nom;
                            Verif.verif(boardGame, symbol, choice, Nomjoueur);
                            compare = true;
                        }

                    }
                }
            }*/
        }
    }
}
