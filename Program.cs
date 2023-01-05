using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] numeri = new int[10];
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                numeri[i] = r.Next(10);
                Console.Write(numeri[i] + " ");
            }
            Console.WriteLine(" ");
            for (int i = 9; i > 4; i--)
            {
                Console.Write(numeri[j] + " ");
                Console.Write(numeri[i] + " ");
                j++;
            }
        }
    }
}
