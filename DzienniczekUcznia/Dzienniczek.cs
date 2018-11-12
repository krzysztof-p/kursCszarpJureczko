using System;
using System.Collections.Generic;
using System.Linq;

namespace DzienniczekUcznia
{
    class Dzienniczek
    {
        // konstruktor

        public Dzienniczek()
        {
            oceny = new List<float>();
        }
        
        // stan

        List<float> oceny;


        // zachowanie metody

        /// <summary>
        /// dodaje ocene od listy
        /// </summary>
        /// <param name="ocena"></param>
        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
        }

        ///// <summary>
        ///// oblicza średnią z ocen
        ///// </summary>
        ///// <returns></returns>
        //public float ObliczSrednia()
        //{
        //    float sum = 0, srednia = 0;

        //    foreach (var ocena in oceny)
        //    {
        //        sum += ocena;
        //    }

        //    srednia = sum / oceny.Count();

        //    return srednia;
        //}

        /// <summary>
        /// Calość statystyk
        /// </summary>
        /// <returns></returns>
        internal DzienniczekStatystyki CaloscStatystyk()
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

        ///// <summary>
        ///// zwraca najlepszą ocenę
        ///// </summary>
        ///// <returns></returns>
        //public float PobierzMaxOcene()
        //{
        //    return oceny.Max();
        //}
        ///// <summary>
        ///// zwraca najgorszą ocenę
        ///// </summary>
        ///// <returns></returns>
        //public float PobierzMinOnene()
        //{
        //    return oceny.Min();
        //}

    }
}
