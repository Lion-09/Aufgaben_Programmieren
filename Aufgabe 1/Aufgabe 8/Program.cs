using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dein Kommentar: ");
        string kommentar = Console.ReadLine();

        string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };

        string kommentarLower = kommentar.ToLower();
        bool hatVerboteneWorte = false;

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            if (kommentarLower.Contains(forbiddenWords[i]))
            {
                Console.WriteLine($"Dein Kommentar enthält ein verbotenes Wort: {forbiddenWords[i]}");
                hatVerboteneWorte = true;
            }
        }

        if (!hatVerboteneWorte)
        {
            Console.WriteLine("Danke für deinen Kommentar.");
        }
    }
}
