using System; 
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Project2
{
    public class Mot
    {
        private int _wordLength;
        private string _password;
       
        public void Word()
        {
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
        }

        public void ChangeLetter()
        {
            ConsoleKeyInfo _letter = Console.ReadKey(true);
            string _letterCompare = Convert.ToString(_letter.KeyChar);
                
            Console.Clear();

            for (int i = 0; i < _password.Length; i++)
            {
                string c = Convert.ToString(_password[i]);
                if (_letterCompare.Contains(c))
                {
                    Console.Write(c);
                }
                else
                {
                    Console.Write(" _ ");
                }

            }
        }

        public void Word_()
        {
            Console.Clear();

            _wordLength = _password.Count();
            Console.Write("\nTon mot comporte {0} caratères: ", _wordLength);

            for(int i = 0; i < _wordLength; i++)
            {
                Console.Write(" _ ");
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