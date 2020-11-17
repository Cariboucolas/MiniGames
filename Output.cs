using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class Output
    {
        public static void Draw(String drawing, ConsoleColor foregroundColor=ConsoleColor.White, ConsoleColor backgroundColor=ConsoleColor.Black)
        {
            ConsoleColor currentForegroundColor = Console.ForegroundColor;
            ConsoleColor currentBackgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(drawing);
            Console.BackgroundColor = currentBackgroundColor;
            Console.ForegroundColor = currentForegroundColor;
        }
    }
}
