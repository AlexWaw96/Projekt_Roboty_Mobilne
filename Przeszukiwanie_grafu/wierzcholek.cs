using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Przeszukiwanie_grafu
{
    public class wierzcholek
    {
        public Point xy;    //Jego pozycja
        public int nr;      //Jego numer identyfikacyjny

        public List<int> sasiedzi;        //Jego sasiedzi
        public List<double> sasiedzi_odl; //Jego sasiedzi odleglosc

        public bool woda;   //Czy na pewno jest na ladzie
        public bool Odwiedzony = false;   // A* 

        public double Dr_do_pkt = -1;  // Koszt dojscia do A*  i Djikstra

        public int poprzednik; // Djikstra

        public wierzcholek()
        {
            sasiedzi = new List<int>();
            sasiedzi_odl = new List<double>();
            poprzednik = -1;
        }

    }

}
