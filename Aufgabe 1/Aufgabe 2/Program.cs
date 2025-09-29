namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days;
            
            Console.WriteLine("Berechnung von Sekundeneines monats in Abhängigkeit seiner Anzahl Tage");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berrechnen wollen?");


            days = Convert.ToInt32(Console.ReadLine());
            int sek = (days * 86400);

            Console.WriteLine("Drücke die Enter Taste");


            string input = Console.ReadLine();

            if (int.TryParse(input, out int value) && (value == 28 || value == 29 || value == 30 || value == 31))
            {
                Console.WriteLine("Ihre Eingabe " + value + " ist gültig.");
                double seconds = days * 86400.0;
                Console.WriteLine("Dein Monat mit " + days + " Tagen " + seconds);
            }

            
            else
            {
                int giveMonth1;
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine gültige Zahl ein.");
                Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekunden berechnen wollen? {Nur 28,29,30,31}");
                giveMonth1 = Convert.ToInt32(Console.ReadLine());
                double seconds = giveMonth1 * 86400.0;
                Console.WriteLine("Dein Monat mit " + giveMonth1 + " Tagen " + seconds);

            }

        }
    }
}
