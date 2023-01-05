using System;
using System.Linq;

namespace Esercizi
{
    public class Test
    {
        public static void Main(string[] args)
        {
            string ricomincia;
            do
            {
                Console.WriteLine("Inserisci numero dell'esercizio da eseguire: ");
                int scelta = int.Parse(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        Esercizio1.Media();
                        break;
                    case 2:
                        Esercizio2.Ristampa();
                        break;
                    case 3:
                        Esercizio3.ReversePrint();
                        break;
                    case 4:
                        Esercizio4.Stampavocali();
                        break;
                    case 5:
                        Esercizio5.Stampalunghezza();
                        break;
                    case 6:
                        Console.Write("Inserisci stringa: ");
                        string stringa = Console.ReadLine();
                        Console.WriteLine("inserisci un numero intero positivo: ");
                        int numero = int.Parse(Console.ReadLine());
                        Esercizio6.StampaStringhe(stringa, numero);
                        break;
                    case 7:
                        Esercizio7.PariEdispari();
                        break;
                    default:
                        Console.WriteLine("Esercizio non esistente! ");
                        break;
                }
                Console.WriteLine("Digita si per ricominciare: ");
                ricomincia = Console.ReadLine();
            } while (ricomincia.ToLower() == "si");
        }
    }
}
