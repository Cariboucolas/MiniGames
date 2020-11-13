using System;
using Project2;
using Project2.Hangman;
using Project2.Tictactoe;


internal class MainClass
{
    private class Program
    {
        private static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                DisplayMainMenu.DisplayWelcomeAndChoice();
                
                string playerChoice = Console.ReadLine();

                if (playerChoice == "1")
                {
                    new HangmanGame().Run();
                }
                else if (playerChoice == "2")
                {
                    new DisplayBoardGame().ChooseName();
                    new DisplayBoardGame().DisplayBoardGames();
                    
                }
                 else
                {
                    Console.WriteLine("Veuillez choisir valeur 1, pour le Pendu, valeur 2 est en en cours de construction.");
                    playerChoice = Console.ReadLine();
                }
            }
        }
    }
}

