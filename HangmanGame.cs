using System; 
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Text;

namespace Project2
{
    public class HangmanGame
    {

        private string _password;
        private bool[] _lettersRevealed;
        private int _life = 10;

        public void DecrementLife()
        {
            if (_life == 0) return;
            _life -= 1;
        }
        // Fait tourner la boucle du jeu
        public void Run()
        {
            Console.Clear();
            _password = ModeChoice.DisplayHangmanMenu();
            PromptWord();

            while (true)
            {
                Console.Clear();
                DisplayWord();

                if (_life == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nPerdu! Le mot était : " + _password);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey(true);
                    return;
                }
                if (WordFind())
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nTu as gagné!");
                    Console.ReadKey(true);
                    return;
                }
                ConsoleKeyInfo _letter = Console.ReadKey(true);
                Char _letterCompare = _letter.KeyChar;

                if (_password.Contains(_letterCompare)) // Si le mot contient la lettre tapée
                {
                    RevealLetters(_letterCompare);
                }
                else
                {
                    DecrementLife();
                }

                
            }
        }
        private bool WordFind()
        {
            for (int i = 0; i < _lettersRevealed.Length; i++)
            {
                if (_lettersRevealed[i] == false)
                {
                    return false;
                }
            }
            return true;
        }

        // Récupère le mot via l'entrée standard
        public void PromptWord()
        {
            Console.Clear();
            _lettersRevealed = new bool[_password.Length];
            for (int i = 0; i < _lettersRevealed.Length; i++)
            {
                _lettersRevealed[i] = false;
            }
        }

        // Révéler dans le tableau de booléens une lettre trouvée dans le mot
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
                if (_lettersRevealed[i] == true)
                {
                    Console.Write(" "+ _password[i]);
                }
                else
                {
                    Console.Write(" _ ");
                }
            }
            Console.Write("\n \n \n ");
            DrawingHangman.DrawStepHangman(_life);
            Console.WriteLine("\nTu possèdes actuellement : " + _life + " vie(s)");
        }
    }
}