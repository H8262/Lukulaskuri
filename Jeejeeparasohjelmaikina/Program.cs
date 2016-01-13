using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeejeeparasohjelmaikina
{
    class Program
    {
        static void Main(string[] args)
        {
            int muuttuja = 0;
            int luku = 0;

            do
            {
                Console.Write("Anna luku: ");
                luku = int.Parse(Console.ReadLine());

                muuttuja = muuttuja + luku;

            } while (luku != 0);

            Console.WriteLine("Lukujen summa on: " + muuttuja);
        }
    }
}
