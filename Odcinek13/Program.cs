using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            dzienniczek.DodajOcene(5);
            dzienniczek.DodajOcene(8.5f);
            dzienniczek.DodajOcene(4.7f);
            dzienniczek.DodajOcene(12);

            DzienniczekStatystyki stat = dzienniczek.CaloscStatystyk();

            Console.WriteLine(Dzienniczek.MaxOcena);
            Console.WriteLine(Dzienniczek.MinOcena);

            Dzienniczek dzienniczek2 = new Dzienniczek();
            Dzienniczek dzienniczek3 = new Dzienniczek();
            Console.WriteLine(Dzienniczek.Licznik);
            Dzienniczek dzienniczek4 = new Dzienniczek();
            Dzienniczek dzienniczek5 = new Dzienniczek();
            Dzienniczek dzienniczek6 = new Dzienniczek();

            Console.WriteLine(Dzienniczek.Licznik);

            Console.ReadKey();

        }
    }
}
