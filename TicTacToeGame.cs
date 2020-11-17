using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class TicTacToeGame : Game
    {
        public override String Name { get => "Tic-Tac-Toe"; }
        public override IEnumerable<Player> Players { get; set; } = new List<Player>();

        public override void Run()
        {
            Console.WriteLine("Coucou je suis le morpion");
            throw new NotImplementedException();
        }
    }
}
