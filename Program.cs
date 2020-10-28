using Project2;
using System;
using System.Collections.Generic;

class MainClass
{
    class Program
    {
        static void Main(string[] args)
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
