using System; 
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Text;

namespace Project2
{
    public class PenduGame
    {

        private static string _password;
        private bool[] _lettersRevealed;

        // Fait tourner la boucle du jeu
        public void Run()
        {
            Console.Clear();
            ModeChoice.DisplayMenuPendu();
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
            _password =  ModeChoice.password();
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
                    Console.Write(" "+ _password[i]);
                }
                else
                {
                    Console.Write(" _ ");
                }
            }
            Console.Write("\n \n \n ");
            DrawingPendu.Draw();
            
            if (Life.GetLife()>0)
            {
                Console.WriteLine("\nTu possèdes actuellement : " + Life.GetLife() + " vie(s)");
            }
            else
            {
                Console.WriteLine("\n Le mot était : " + _password);
                Console.Write("\n Tu es mort!");
                Console.Write("\n Si tu veux rejouer clic sur entrer? ");

                //ConsoleKeyInfo keyInfo;
                //keyInfo = Console.ReadKey(true);
                //if(keyInfo.Key != ConsoleKey.Enter)
                //{
                //    Environment.Exit(-1);
                //}
                //else
                //{

                //    Life.SetLife(Life.GetLife() + 10);
                //    _password = RandomPendu.RandomPendus();
                    
                //    MainMenu.DisplayWelcome();

                //    new PenduGame();

                //}
        }
    }
    }
}