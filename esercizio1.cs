using System;
using System.Linq;

namespace Esercizi
{
    public class Esercizio1
    {
        public static void Media()
        {
            int[] numeri = new int[8];
            int[] newNumeri = new int[8];
            int cont = 0, j = 0;
            float somm = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Inserisci il " + (i + 1) + " numero: ");
                numeri[i] = int.Parse(Console.ReadLine());
                if (numeri[i] % 7 == 0)
                {
                    somm += numeri[i];
                    newNumeri[j] = numeri[i];
                    cont++;
                    j++;
                    Console.WriteLine("Numero multiplo di 7!");
                }
            }
            float media = somm / cont;
            Console.WriteLine("la media dei numeri multipli di 7 e': " + media);
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("multiplo di 7:" + newNumeri[i]);
            }
        }
    }
}
