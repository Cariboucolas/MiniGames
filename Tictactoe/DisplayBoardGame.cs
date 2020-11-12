using System;

namespace Project2.Tictactoe
{
    public class DisplayBoardGame
    {
        public void DisplayBoardGames()
        {
            while(true)
            {
                char[] boardGame = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                Console.Clear();
                Console.WriteLine("  -------------------------");
                Console.WriteLine("  |       |       |       |");
                Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", boardGame[0], boardGame[1], boardGame[2]);
                Console.WriteLine("  |       |       |       |");
                Console.WriteLine("  -------------------------");
                Console.WriteLine("  |       |       |       |");
                Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", boardGame[3], boardGame[4], boardGame[5]);
                Console.WriteLine("  |       |       |       |");
                Console.WriteLine("  -------------------------");
                Console.WriteLine("  |       |       |       |");
                Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", boardGame[6], boardGame[7], boardGame[8]);
                Console.WriteLine("  |       |       |       |");
                Console.WriteLine("  -------------------------");
                Console.ReadLine();
            }
        }
        
    }
}
