using System;
using System.Linq;

namespace Esercizi
{
    public class Esercizio4
    {
        public static void Stampavocali()
        {
            Console.WriteLine("digita una parola o una frase: ");
            string line = Console.ReadLine();
            int lunghezza = line.Length;
            char[] caratteri = new char[lunghezza];
            for (int i = 0; i < lunghezza; i++)
            {
                caratteri[i] = line[i];
            }
            for (int i = 0; i < lunghezza; i++)
            {
                caratteri[i] = char.ToLower(caratteri[i]);
                if (caratteri[i] == 'a' || caratteri[i] == 'e' || caratteri[i] == 'i' || caratteri[i] == 'o' || caratteri[i] == 'u')
                {
                    Console.Write(caratteri[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
