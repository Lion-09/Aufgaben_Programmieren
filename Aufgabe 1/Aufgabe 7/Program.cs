namespace Aufgabe_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwischen 1 und 30, die durch 5 und/oder 3 ohne Rest teilbar sind:");
            Console.WriteLine("-------------------------------------------------------------------------");

            int i = 1;

            while (i <= 30)
            {
                i++;

                if (i % 5 == 0 || i % 3 == 0)
                {
                    if (i < 30)
                    Console.Write(i + ", ");
                    
                    else
                    {
                        Console.Write(i + "\n");
                    }
                }

                

            }

        }
    }
}
