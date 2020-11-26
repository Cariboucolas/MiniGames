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

            
            Player player1 = NewPlayer('X', 1, ConsoleColor.Red);
            Player player2 = NewPlayer('O', 2, ConsoleColor.Blue);

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

            char[] boardGame = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var currentPlayer = player1;
            while(true)
            { 
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

                if (IsPlayerWin(boardGame, currentPlayer.PlayerSymbol))
                {
                    Console.WriteLine(currentPlayer.PlayerName + " a gagné!!!");
                    Console.ReadLine();
                    return;
                }

                Console.Write("\n" + currentPlayer.PlayerName + " à vous de jouer : ");

                var selectedCase = Convert.ToInt16(Console.ReadLine());
                if (IsSelectedCase(selectedCase,boardGame))
                {
                    Console.WriteLine("Cette case est déja prise, choisissez-en une autre :");
                    Console.ReadLine();
                    continue;
                }

                // IsPlayerEqual(boardGame, currentPlayer.PlayerSymbol);

                boardGame[selectedCase - 1] = currentPlayer.PlayerSymbol;
                if (IsPlayerWin(boardGame, currentPlayer.PlayerSymbol) == false)
                {
                    if (currentPlayer == player1)
                    {
                        currentPlayer = player2;
                    }
                    else if (currentPlayer == player2)
                    {
                        currentPlayer = player1;
                    }
                }
                
                // ou
                // currentPlayer = currentPlayer == player1 ? player2 : player1;
            }
        }

        private bool IsPlayerWin(char[] boardGame, char currentPlayer)
        {
            var symbol = currentPlayer;
            return boardGame[0] == symbol && boardGame[1] == symbol && boardGame[2] == symbol ||
                   boardGame[3] == symbol && boardGame[4] == symbol && boardGame[5] == symbol ||
                   boardGame[6] == symbol && boardGame[7] == symbol && boardGame[8] == symbol ||

                   boardGame[0] == symbol && boardGame[3] == symbol && boardGame[6] == symbol ||
                   boardGame[1] == symbol && boardGame[4] == symbol && boardGame[7] == symbol ||
                   boardGame[2] == symbol && boardGame[5] == symbol && boardGame[8] == symbol ||

                   boardGame[0] == symbol && boardGame[4] == symbol && boardGame[8] == symbol ||
                   boardGame[2] == symbol && boardGame[4] == symbol && boardGame[6] == symbol;
        }

        /*private void IsPlayerEqual(char[] boardGame, char currentPlayer)
        {
            for (int i = 0; i < boardGame.Length; i++)
            {
                if (boardGame.Length == selectedCase )
                {
                    Console.WriteLine("Vous êtes ex aequo.");
                }
            }
        }*/

        private bool IsSelectedCase(short selectedCase, char[] boardGame)
        {
            var selectedValue = boardGame[selectedCase - 1];
            return selectedValue == 'X' || selectedValue == 'O';
        }

        public Player NewPlayer(char symbol, int numero, ConsoleColor color )
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
