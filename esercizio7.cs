using System;
using System.Linq;

namespace Esercizi
{
    public class Esercizio7
    {
        public static void PariEdispari()
        {
            int[] numeri = new int[10];
            Random r = new Random();
            float somm1 = 0, somm2 = 0;
            for (int i = 0; i < 10; i++)
            {
                numeri[i] = r.Next(10);
                if (i % 2 == 0)
                {
                    somm1 += numeri[i];
                }
                else
                {
                    somm2 += numeri[i];
                }
            }
            if (somm1 == somm2)
            {
                Console.WriteLine("Pari e dispari uguali ");
            }
            else
            {
                Console.WriteLine("Pari e dispari diversi ");
            }
        }
    }
}
