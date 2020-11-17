using System;
using System.Collections.Generic;

namespace Project2
{
    internal abstract class Game
    {
        public abstract String Name { get; }
        public abstract void Run();
        public abstract IEnumerable<Player> Players { get; set; } 
    }
}