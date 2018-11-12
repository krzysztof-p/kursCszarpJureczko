using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Program
    {
        static void NadajNazwe(ref Dzienniczek dzienniczek)
        {
            dzienniczek = new Dzienniczek();
            dzienniczek.nazwa = "dzienniczek Marcina";
        }

        static void ZwiekszLiczbe(ref int liczba)
        {
            liczba += 1;
        }

        static void Main(string[] args)
        {
            // PrzekazaniePrzezWartoscIRef();

            //string name1 = "Marcin";
            //string name2 = "marcin";

            //bool test = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);

            //Console.WriteLine(test);

            //zachowanieTypow();

            Arrays();

            Console.ReadKey();
        }

        private static void Arrays()
        {
            float[] ratings;
            ratings = new float[4];

            AddRatings(ratings);


            foreach (var rating in ratings)
            {
                Console.WriteLine(rating);
            }
        }

        private static void AddRatings(float[] oceny)
        {
            oceny[0] = 4.2f;
            oceny[1] = 3.2f;
            oceny[2] = 9.4f;
            oceny[3] = 5.7f;
        }

        private static void zachowanieTypow()
        {
            string name = " Marcin ";
            name = name.Trim();
            DateTime date = new DateTime(2017, 1, 12);
            date = date.AddHours(48);
            
            Console.WriteLine(name);
            Console.WriteLine(date);
        }

        private static void PrzekazaniePrzezWartoscIRef()
        {
            Dzienniczek d1 = new Dzienniczek();
            Dzienniczek d2 = d1;

            NadajNazwe(ref d2);

            Console.WriteLine(d2.nazwa);

            int x1 = 4;
            int x2 = x1;

            ZwiekszLiczbe(ref x1);

            Console.WriteLine(x1);
        }
    }
}
