﻿namespace ConsoleHalloWereled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, Wereld!");
            Console.Write("Hoe heet je: ");
            string naam = Console.ReadLine();
            Console.WriteLine($"Aangename kennismaking, {(naam == "Ilias" ? "Ilias" : "onbekende")}");
            Console.WriteLine("druk een toets om verder te gaan...");
            Console.ReadKey();
        }
    }
}