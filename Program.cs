using System;
using System.Linq;
using System.Collections.Generic;
using Project2;

internal class MainClass
{
    private class Program
    {
        private static void Main(string[] args)
        {

            while(true)
            {
                Console.Clear();
                DisplayMainMenu.DisplayWelcomeAndChoice();
                string playerChoice = Console.ReadLine();

                if (playerChoice == "1")
                {
                    new HangmanGame().Run();
                }
                /*else if (playerChoice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("WORK IN PROGRESS");
                }*/
                else
                {
                    Console.WriteLine("Veuillez choisir valeur 1, pour le Pendu, valeur 2 est en en cours de construction.");
                    playerChoice = Console.ReadLine();
                }
            }
        }
    }
}

