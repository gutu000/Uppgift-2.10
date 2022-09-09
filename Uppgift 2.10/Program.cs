using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken bok är din favoritbok?");
            string bok = Console.ReadLine();
            Console.WriteLine("Boken heter Programmering 1");
            string Boken = Console.ReadLine();

            Console.WriteLine("Hej, jag hoppas jag kan hitta och läsa den boken, den låter väldigt intressant" + bok + Boken);

        }
    }
}