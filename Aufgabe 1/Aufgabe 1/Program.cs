namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Zahl 1:");
            int zahl1 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Zahl 2:");
            int zahl2 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Summe: ");
           

            int Summe = zahl1 + zahl2;

            Console.WriteLine(Summe);

  
        }
    }
}
