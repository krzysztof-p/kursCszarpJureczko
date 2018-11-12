using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            Osoba osoba2 = new Osoba(1, "Tomek");
            Osoba osoba3 = new Osoba(2, "Tomek", "Nowak");
            Osoba osoba4 = new Osoba(2, "Tomek", "Nowak", "Katoeice", 18, "meszczyzna");
        }
    }
}
