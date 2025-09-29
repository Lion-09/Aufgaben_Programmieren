namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie eine Zahl ein: "); 
            int zahl = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (zahl != 0)
            {
                sum = sum + (zahl % 10); 
                zahl = zahl / 10;        
            }

            Console.WriteLine("Die Ziffernsumme ist: " + sum);
            Console.ReadLine();
        } 

