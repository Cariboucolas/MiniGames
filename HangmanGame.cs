using System;
using System.Collections.Generic;

namespace Project2
{
    class HangmanGame : Game
    {
        private string _password;
        private bool[] _lettersRevealed;
        private int _life = 10;

        public override String Name { get => "Hangman"; }
        public override IEnumerable<Player> Players { get; set; } = new List<Player>();

        public void DecrementLife()
        {
            if (_life == 0) return;
            _life -= 1;
        }

        public override void Run()
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
            for (int i = 0; i < _password.Length; i++)
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
                    Console.Write(" " + _password[i]);
                }
                else
                {
                    Console.Write(" _ ");
                }
            }
            Console.Write("\n \n \n ");
            DrawStep(_life);
            Console.WriteLine("\nTu possèdes actuellement : " + _life + " vie(s)");
        }

        public void DrawStep(int life)
        {
            switch (life)
            {
                case 0:
                    Console.WriteLine("     ========= Y ===");
                    Console.WriteLine("     ||  /      |    ");
                    Console.WriteLine("     || /       |    ");
                    Console.WriteLine("     ||/        O    ");
                    Console.WriteLine("     ||        /|\\  ");
                    Console.WriteLine("     ||        / \\  ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("    /||              ");
                    Console.WriteLine("   //||              ");
                    Console.WriteLine("  ============       ");

                    break;
                case 1:
                    Console.WriteLine("     ========= Y ===");
                    Console.WriteLine("     ||  /      |    ");
                    Console.WriteLine("     || /       |    ");
                    Console.WriteLine("     ||/        O    ");
                    Console.WriteLine("     ||        /|\\  ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("    /||              ");
                    Console.WriteLine("   //||              ");
                    Console.WriteLine("  ============       ");

                    break;
                case 2:
                    Console.WriteLine("     ========= Y ===");
                    Console.WriteLine("     ||  /      |    ");
                    Console.WriteLine("     || /       |    ");
                    Console.WriteLine("     ||/        O    ");
                    Console.WriteLine("     ||         |    ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("    /||              ");
                    Console.WriteLine("   //||              ");
                    Console.WriteLine("  ============       ");

                    break;
                case 3:
                    Console.WriteLine("     ========= Y ===");
                    Console.WriteLine("     ||  /      |    ");
                    Console.WriteLine("     || /       |    ");
                    Console.WriteLine("     ||/        O    ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("    /||              ");
                    Console.WriteLine("   //||              ");
                    Console.WriteLine("  ============       ");

                    break;
                case 4:
                    Console.WriteLine("     ========= Y ===");
                    Console.WriteLine("     ||  /      |    ");
                    Console.WriteLine("     || /       |    ");
                    Console.WriteLine("     ||/             ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("    /||              ");
                    Console.WriteLine("   //||              ");
                    Console.WriteLine("  ============       ");

                    break;
                case 5:
                    Console.WriteLine("     ========= Y ===");
                    Console.WriteLine("     ||  /           ");
                    Console.WriteLine("     || /            ");
                    Console.WriteLine("     ||/             ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("    /||              ");
                    Console.WriteLine("   //||              ");
                    Console.WriteLine("  ============       ");

                    break;
                case 6:
                    Console.WriteLine("                     ");
                    Console.WriteLine("     ||  /           ");
                    Console.WriteLine("     || /            ");
                    Console.WriteLine("     ||/             ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("    /||              ");
                    Console.WriteLine("   //||              ");
                    Console.WriteLine("  ============       ");

                    break;
                case 7:
                    Console.WriteLine("                     ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("    /||              ");
                    Console.WriteLine("   //||              ");
                    Console.WriteLine("  ============       ");

                    break;
                case 8:
                    Console.WriteLine("                     ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("     ||              ");
                    Console.WriteLine("  ============       ");

                    break;
                case 9:
                    Console.WriteLine("                     ");
                    Console.WriteLine("                     ");
                    Console.WriteLine("                     ");
                    Console.WriteLine("                     ");
                    Console.WriteLine("                     ");
                    Console.WriteLine("                     ");
                    Console.WriteLine("                     ");
                    Console.WriteLine("                     ");
                    Console.WriteLine("                     ");
                    Console.WriteLine("  ============       ");

                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nTentes de trouver le mot.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }
    }
}
