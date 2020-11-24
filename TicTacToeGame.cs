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

            new DisplayBoardGame().DisplayChooseName();
            new Player().GetDisplayName();

        }
        public void CheckingSymbol()
        {

            
            //char symbol;
            //char symbolX = Convert.ToChar(88);
            //char symbolO = Convert.ToChar(79);
            //bool win = false;
            //bool compare = false;
          

            //while (win != true)
            //{
            //    if (symbol == player1.symbol)
            //    {

            //        compare = false;
            //        while (compare != true)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.WriteLine("       A toi de jouer " + player1.Nom);
            //            string choice = Console.ReadLine();
            //            int value = Convert.ToInt32(choice);
            //            DisplayBoardGame boardGame = new DisplayBoardGame();
            //            if (boardGame.DisplayBoardGames() == symbolX || boardGame[value] == symbolO)
            //            {
            //                Console.WriteLine(" Impossible case déjà prise Rejouer ");


            //            }
            //            else
            //            {
            //                symbol = player1.Symbole;
            //                string Nomjoueur = player1.Nom;
            //                Verif.verif(boardGame, symbol, choice, Nomjoueur);
            //                compare = true;
            //            }

            //        }
            //    }
            //}
        }
    }
}
