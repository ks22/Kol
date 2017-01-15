using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw4
{
    class Student : Osoba
    {
        //deklracaja dodatkowych pol do klasy potomnej
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        //konstruktor domyslny
        public Student()
        {
            rok = 2;
            numerGrupy = 3;
            numerAlbumu = 34000;
        }
        //metoda wyswietlajaca informacje
        public void WypiszInfo()
        {

        }
    }
}
