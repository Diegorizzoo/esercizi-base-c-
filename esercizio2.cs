using System;
using System.Linq;

namespace Esercizi
{
    public class Esercizio2
    {
        public static void Ristampa()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Inserisci " + (i + 1) + " lettera: ");
                char stampa = Console.ReadLine()[0];
                Console.WriteLine(stampa);
            }
        }
    }
}
