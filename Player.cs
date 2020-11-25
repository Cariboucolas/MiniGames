using System;

namespace Project2
{
    public class Player
    {
        public string PlayerName { get; set; }

        public char PlayerSymbol { get; set; }

        public override string ToString()
        {
            return this.PlayerName + " ton symbole est : " + this.PlayerSymbol;

        }
    }
    
}
