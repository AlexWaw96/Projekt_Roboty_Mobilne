using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Przeszukiwanie_grafu
{
    class Rysowanie
    {

        public Rysowanie()
        {

        }


        public Bitmap kropka( Bitmap x, Point l)
        {
            for (int i = -3; i < 4; i++)
                for (int k = -3; k < 4; k++)
                { x.SetPixel(l.X + i, l.Y + k, Color.Red); }

            return x;
        }

        public Bitmap kropka(Bitmap x, Point l, int size)
        {
            for (int i = -size; i < size+1; i++)
                for (int k = -size; k < size+1; k++)
                { x.SetPixel(l.X + i, l.Y + k, Color.Blue); }

            return x;
        }

    }
}
