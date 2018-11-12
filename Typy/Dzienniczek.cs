using System;
using System.Collections.Generic;
using System.Linq;

namespace Typy
{
    class Dzienniczek
    {
        // konstruktor
        public Dzienniczek()
        {
            oceny = new List<float>();
            Licznik++;
        }
        
        // stan
        private List<float> oceny;
        public string nazwa;
        public static float MinOcena = 0;
        public static float MaxOcena = 10;
        public static long Licznik = 0;


        // zachowanie metody
        /// <summary>
        /// dodaje ocene od listy
        /// </summary>
        /// <param name="ocena"></param>
        public void DodajOcene(float ocena)
        {
            if (ocena >=0 && ocena<= 10)
            {
                oceny.Add(ocena);
            }
            
        }

        /// <summary>
        /// Całość statystyk
        /// </summary>
        /// <returns></returns>
        public DzienniczekStatystyki CaloscStatystyk()
        {
            DzienniczekStatystyki statystyki = new DzienniczekStatystyki();
            float sum = 0;

            foreach (var ocena in oceny)
            {
                sum += ocena;
            }

            statystyki.SredniaOcen = sum / oceny.Count();
            statystyki.MaxOcena = oceny.Max();
            statystyki.MinOcena = oceny.Min();

            return statystyki;
        }
    }
}
