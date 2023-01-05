using System;
using System.Linq;

namespace Esercizi
{
    public class Esercizio5
    {
        public static void Stampalunghezza()
        {
            bool flag = true;
            const int max = 50;
            string[] arrayStringhe = new string[max];
            int i = 0, cont = 0;
            int somm = 0;
            while (flag == true)
            {
                cont++;
                Console.Write("Inserisci stringa: ");
                arrayStringhe[i] = Console.ReadLine();
                Console.WriteLine("Vuoi inserire un altra stringa? digita si per continuare ");
                string s = Console.ReadLine();
                if (s.CompareTo("si") == 0 || s.CompareTo("Si") == 0)
                {
                    i++;
                }
                else
                {
                    flag = false;
                    arrayStringhe[i + 1] = " ";
                    cont++;
                }
            }
            for (i = 0; i < cont; i++)
            {
                if (char.IsUpper(arrayStringhe[i][0]))
                {
                    somm += arrayStringhe[i].Length;
                }
            }
            Console.WriteLine("La lunghezza delle stringhe che iniziano con una lettera maiuscola è: " + somm);
        }
    }
}
