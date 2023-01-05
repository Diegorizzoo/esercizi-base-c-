using System;
using System.Linq;

namespace Esercizi
{
    public class Esercizio6
    {
        public static void StampaStringhe(string line, int numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("ERRORE: numero negativo");
            }
            else
            {
                for (int i = 0; i < numero; i++)
                {
                    Console.Write(line + " ");
                }
            }
        }
    }
}
