namespace Project2
{
    internal class MainClass
    {
        private class Program
        {
            private static void Main(string[] args)
            {
               
                    GameChooser chooser = new GameChooser();
                    chooser.DisplayMenu();
                    Game game = chooser.Choose();
                    game.Run();
                
                
            }
        }
    }
}

