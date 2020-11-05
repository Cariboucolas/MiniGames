using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class DrawingPendu
    {

        public static void Draw()
        {
            int caseSwitch = Life.GetLife();

            switch (caseSwitch)
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
                    Console.WriteLine("\n A toi de jouer ");
                    break;
            }
        }
    }
}
