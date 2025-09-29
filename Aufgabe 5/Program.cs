using System.Data.SqlTypes;

namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            int km = Convert.ToInt32(Console.ReadLine());


            if (km > 42)
            {
                Console.WriteLine("Das schaffst du nicht");
                Console.ReadLine();
            }

            else if (km < 42)
            {

                double anzahlrunden = (km / 0.4);
                Console.WriteLine("Das sind " + anzahlrunden + " Runden");
                Console.WriteLine("Bist du bereit? (0 für Ja oder 1 für Nein)");
                int ready = Convert.ToInt32(Console.ReadLine());

                if (ready == 0)
                {
                    int i = 0;

                    while (i < anzahlrunden)
                    {
                        i++;
                        Console.WriteLine("Du läufst gerade Runde " + i);
                    }
                    Console.WriteLine("Du hast es geschafft!");
                    Console.ReadLine();
                }

                else if (ready == 1)
                {
                    Console.WriteLine("Komme wieder wenn du dich ready fühlst");
                    Console.ReadLine();
                }
            }


        }
    }
}
