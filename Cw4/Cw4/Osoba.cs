using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw4
{
    class Osoba
    {
        //definicja pol z modyfikatorem protected
        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;

        //konstrukto domyslny
        public Osoba()
        {
            imie = "Jan";
            nazwisko = "Nowak";
            rokUrodzenia = 1996;
        }
        //konstruktor z parametrami
        public Osoba(string imie, string nazwisko, int rokUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
        }
        //metoda wyswietlajaca informacje
        public void WypiszInfo()
        {
            Console.WriteLine("Imię i nazwisko: {0} {1}", imie, nazwisko);
            Console.WriteLine("Rok urodzenia: {0}", rokUrodzenia);
            Console.WriteLine("Rok urodzenia: {0}", rok);
            Console.WriteLine("Rok urodzenia: {0}", numerGrupy);
            Console.WriteLine("Rok urodzenia: {0}", numerAlbumu);
            
        }
        //konstruktor z parametrami
        public Student (string imie, string nazwisko, int rokUrodzenia, int rok, int numerGrupy, int numerAlbumu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.rok = rok;
        }
        
    }
}
