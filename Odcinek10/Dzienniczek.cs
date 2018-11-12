using System;
using System.Collections.Generic;
using System.Linq;

namespace Odcinek10
{
    class Dzienniczek
    {
        //konstruktor

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
        /// <param name="ocena">nowa ocena</param>
        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
        }
        /// <summary>
        /// oblicza średnią z ocen
        /// </summary>
        /// <returns>zwraca średnią ocen</returns>
        public float ObliczSrednia()
        {
            float sum = 0, srednia = 0;

            foreach (var ocena in oceny)
            {
                sum += ocena;
            }

            srednia = sum / oceny.Count();

            return srednia;
        }
        /// <summary>
        /// zwraca najlepszą ocenę
        /// </summary>
        /// <returns></returns>
        public float PobierzMaxOcene()
        {
            return oceny.Max();
        }
        /// <summary>
        /// zwraca najgorszą ocenę
        /// </summary>
        /// <returns></returns>
        public float PobierzMinOnene()
        {
            return oceny.Min();
        }

    }
}
