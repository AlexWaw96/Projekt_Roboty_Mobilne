using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Przeszukiwanie_grafu
{
    class Metody_Pomocnicze
    {


        public Metody_Pomocnicze()
        { }


        public double Odleglosc(Point poczatek, Point koniec) // int odl = Odleglosc(wierzcholki[z], wierzcholki[i]);
        {
            double dx = Math.Abs(koniec.X - poczatek.X);
            double dy = Math.Abs(koniec.Y - poczatek.Y);

            return Math.Sqrt(dx * dx + dy * dy);
        }

       

    }
}
