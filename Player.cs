using System;

namespace Project2
{
    public class Player
    {
        public string PlayerName { get; set; }

        public void ChooseName()
        {
            PlayerName = Console.ReadLine();
        }
        public string GetDisplayName()
        {
           return PlayerName;
        }
       




    }
}
