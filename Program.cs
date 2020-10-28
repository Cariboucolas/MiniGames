using Project2;
using System;
using System.Linq;

internal class MainClass
{
    private class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("**                                    **");
            Console.WriteLine("**             Wild Games             **");
            Console.WriteLine("**                                    **");
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");


            Mot.Word();
            Life afficherLife = new Life();
            Console.WriteLine("\nTu possèdes actuellement : " + afficherLife.GetLife() + " vie(s).");
        }
    }
}