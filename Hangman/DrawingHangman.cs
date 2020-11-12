using System;

namespace Project2.Hangman
{
    class DrawingHangman
    {

        public static void DrawStepHangman(int life)
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
