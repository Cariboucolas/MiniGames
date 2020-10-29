using System; 
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Project2
{
    public class Mot
    {
        private int _wordLength;
        private string _password;
        private bool[] _lettersRevealed;

        // Fait tourner la boucle du jeu
        public void Run()
        {
            PromptWord();
            while (Life.GetLife() > 0)
            {
                Console.Clear();
                ConsoleKeyInfo _letter = Console.ReadKey(true);
                Char _letterCompare = _letter.KeyChar;

                if (_password.Contains(_letterCompare)) // Si le mot contient la lettre tapée
                {
                    RevealLetters(_letterCompare);
                }
                else
                {
                    Life.SetLife(Life.GetLife() - 1);
                }
                DisplayWord();
            }
        }

        // Récupère le mot via l'entrée standard
        public void PromptWord()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Entre un mot en français : ");
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Spacebar)
                {
                    _password += keyInfo.KeyChar;
                    Console.Write("*");
                }
            }
            while (keyInfo.Key != ConsoleKey.Enter);
            _lettersRevealed = new bool[_password.Length];
            for (int i = 0; i < _lettersRevealed.Length; i++)
            {
                _lettersRevealed[i] = false;
            }
        }

        // Révéler dans le tableau de booléens une lettres trouvée dans le mot
        private void RevealLetters(char letter)
        {
            for (int i=0; i < _password.Length; i++)
            {
                if (_password[i] == letter)
                {
                    _lettersRevealed[i] = true;
                }
            }
        }

        // Afficher le mot en fonction du tableau de booléens
        private void DisplayWord()
        {
            for (int i = 0; i < _password.Length; i++)
            {
                if (/* si il y a true à l'indice i, affiche la lettre */true)
                {
                    Console.Write(_password[i]);
                }
                else
                {
                    Console.Write(" _ ");
                }
            }
        }
                
        public void DisplayMenuMot()
        {
            Console.WriteLine(" ********");
            Console.WriteLine(" **    |");
            Console.WriteLine(" **    @");
            Console.WriteLine(" **   // ");
            Console.WriteLine(" **   // ");
            Console.WriteLine(" **      ");
            Console.WriteLine("**********");
        }
    }
}