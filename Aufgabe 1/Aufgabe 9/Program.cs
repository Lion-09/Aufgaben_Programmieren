using System;

namespace Aufgabe_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ganzzahlige Dezimalzahl (q to Quit): ");
                string eingabe = Console.ReadLine();

                if (eingabe.ToLower() == "q")
                {
                    break; 
                }

                if (int.TryParse(eingabe, out int dezimal))
                {
                    string binaer = Convert.ToString(dezimal, 2);

                    Console.WriteLine($"Dezimal: {dezimal}");
                    Console.WriteLine($"Binär:   {binaer}");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte eine ganze Zahl eingeben.");
                }

                Console.WriteLine(); 
            }
        }
    }
}
