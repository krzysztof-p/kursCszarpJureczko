using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzienniczekUcznia
{
    class Program
    {
        static void Main(string[] args)
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            dzienniczek.DodajOcene(5);
            dzienniczek.DodajOcene(8.5f);
            dzienniczek.DodajOcene(4.7f);
            dzienniczek.DodajOcene(6.4f);

            DzienniczekStatystyki stat = dzienniczek.CaloscStatystyk();

            Console.WriteLine("Średnia ocen: " + stat.SredniaOcen);
            Console.WriteLine("Max ocena: " + stat.MaxOcena);
            Console.WriteLine("Min ocena: "+ stat.MinOcena);

            Dzienniczek dzienniczek2 = new Dzienniczek();
            dzienniczek2.DodajOcene(2);
            dzienniczek2.DodajOcene(2.5f);
            dzienniczek2.DodajOcene(5.7f);
            dzienniczek2.DodajOcene(9.7f);

            stat = dzienniczek2.CaloscStatystyk();

            Console.WriteLine("Średnia ocen: " + stat.SredniaOcen);
            Console.WriteLine("Max ocena: " + stat.MaxOcena);
            Console.WriteLine("Min ocena: " + stat.MinOcena);


            //float sred = dzienniczek.ObliczSrednia();
            //float min = dzienniczek.PobierzMinOnene();
            //float max = dzienniczek.PobierzMaxOcene();

            //for (; ; )
            //{
            //    Console.WriteLine("Podaj ocenę z zakresu 1 do 10");
            //    float ocena;
            //    bool result= float.TryParse(Console.ReadLine(), out ocena);

            //    if (ocena == 11)
            //    {
            //        break;
            //    }
            //    if (result == true)
            //    {
            //        if (ocena>0 && ocena <= 10)
            //        {
            //            dzienniczek.DodajOcene(ocena);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Błędnie podana ocena. Podaj z zakresu 1 - 10");
            //        }
            //    }

            //}
            //Console.WriteLine("Średnia ocen to: " + dzienniczek.ObliczSrednia());
            //Console.WriteLine("Najwyższa ocena: " + dzienniczek.PobierzMaxOcene());
            //Console.WriteLine("Najniższa ocena: " + dzienniczek.PobierzMinOnene());

            Console.ReadKey();
        }
    }
}
