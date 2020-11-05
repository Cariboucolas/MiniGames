using System;
using System.Linq;
using System.Collections.Generic;
using Project2;

internal class MainClass
{
    private class Program
    {
        private static PenduGame _word = new PenduGame();
        private static void Main(string[] args)
        {
            
            MainMenu.DisplayWelcome();

            string playerChoice = Console.ReadLine();

            while(true)
            {
                    if (playerChoice == "1")
                {
                    //lance le pendu
                    _word.Run();
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

