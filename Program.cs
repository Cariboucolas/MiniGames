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
                /*else if (playerChoice == 2)
                {

                // lance le morpion
                    GameChoiceTwo();
                }*/
                else
                {
                    Console.WriteLine("Veuillez choisir une valeur 1, pour le Pendu ou 2, pour le Morpion.");
                    playerChoice = Console.ReadLine();
                }
            }
        }
    }
}

