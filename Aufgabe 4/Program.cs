using System.Data;

namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };

            Console.WriteLine("Wilkommen zum Monats zähler. \n\n\n");

            Console.Write("Zahl:    ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monat:   " + months[month - 1]);


            Console.WriteLine("\n\n\nZum schliesen von diesem Fenster, drücke irgend eine Taste...");
            Console.ReadKey();
        }
    }
}
