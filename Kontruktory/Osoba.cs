using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontruktory
{
    class Osoba
    {
        //stan - zmienne, pola
        int id;
        string imie;
        string nazwisko;
        string adres;
        int wiek;
        string plec;

        //konstruktory
        public Osoba()
        {
            id = 1;
            imie = "Marcin";
            nazwisko = "Kowalski";
            wiek = 14;
        }
        public Osoba(int id, string imie, string nazwisko, string adres, int wiek, string plec)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = adres;
            this.wiek = wiek;
            this.plec = plec;
        }
        public Osoba(int id, string imie, string nazwisko)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            adres = "Katowice";
            wiek = 18;
        }
        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
        }

    }
}
