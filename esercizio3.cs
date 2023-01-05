using System;
using System.Linq;

namespace Esercizi
{
    public class Esercizio3
    {
        public static void ReversePrint()
        {
            Console.WriteLine("digita una parola o una frase: ");
            string line = Console.ReadLine();
            int lunghezza = line.Length;
            char[] caratteri = new char[lunghezza];
            for (int i = 0; i < lunghezza; i++)
            {
                caratteri[i] = line[i];
            }
            for (int i = lunghezza - 1; i > -1; i--)
            {
                Console.Write(caratteri[i]);
            }
            Console.WriteLine();
        }
    }
}
