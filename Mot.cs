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
       // private int _wordLength;
        private string _password;
        private bool[] _lettersRevealed;

        // Fait tourner la boucle du jeu
        public void Run()
        {
            PromptWord();
            DisplayWord();
            while (Life.GetLife() >= 0)
            {
                Console.Clear();
                DisplayWord();
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
                if (/* si il y a true à l'indice i, affiche la lettre */_lettersRevealed[i] == true)
                {
                    Console.Write(_password[i]);
                }
                else
                {
                    Console.Write(" _ ");
                    

                }
                
            }
            Console.Write("\n ");
            Dessin();
            Console.WriteLine("\nTu possèdes actuellement :" + Life.GetLife() + " vie");

        }
                
        public static void Dessin()
        {
            int caseSwitch = Life.GetLife();

            switch (caseSwitch)
            {
                case 0:
                    Console.WriteLine("     ========== Y ===");
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
                    Console.WriteLine("     ========== Y ===");
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
                    Console.WriteLine("     ========== Y ===");
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
                    Console.WriteLine("     ========== Y ===");
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
                    Console.WriteLine("     ========== Y ===");
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
                    Console.WriteLine("     ========== Y ===");
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
                    Console.WriteLine("\n A toi de jouer ");
                    break;
            }
        }
    }
}