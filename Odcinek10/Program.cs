using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dzienniczek dzienniczek = new Dzienniczek();

            dzienniczek.DodajOcene(5);
            dzienniczek.DodajOcene(3);

            Dzienniczek dzienniczek2 = dzienniczek;

            dzienniczek2.DodajOcene(4);

            Dzienniczek dzienniczek3 = dzienniczek2;

            dzienniczek3.DodajOcene(2);

            dzienniczek.ObliczSrednia();

        }
    }
}
