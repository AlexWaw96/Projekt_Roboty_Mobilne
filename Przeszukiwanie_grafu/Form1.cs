using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Przeszukiwanie_grafu
{
    public partial class Form1 : Form
    {
        swiat Planeta = new swiat();
        Metody_Pomocnicze PM = new Metody_Pomocnicze();
        Rysowanie Rysuj = new Rysowanie();

        private Algorytm1 Al1 = new Algorytm1();
        private Algorytm2 Al2 = new Algorytm2();
        private Algorytm3 Al3 = new Algorytm3();

        Pen blackPen = new Pen(Color.Black, 3);
        Pen bluePen = new Pen(Color.Blue, 3);
        Pen greenPen = new Pen(Color.Green, 13);
        public Form1(){
            InitializeComponent();      
            pictureBox1.Image = Planeta.Mapa;
        }

        private void button1_Click(object sender, EventArgs e) //rysuj GRAF z wierzcholkow
        {
            grafButton.Enabled = false;
            uruchomAlgorytmToolStripMenuItem.Enabled = true;
            Planeta.Stworz_graf();
            pictureBox1.Image = Planeta.Mapa;
        }

        private void wierzcholkiButton_Click(object sender, EventArgs e)
        {

            Planeta.Generuj_Wierzcholek(liczbaWierzcholkow.Value);
            
            pictureBox1.Image = Planeta.Mapa;
            grafButton.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Wyznaczanie miejsca klikniecia i naniesienie na mape
            MouseEventArgs ff = (MouseEventArgs)e;
            Point x = new Point(ff.X, ff.Y);

            float a = pictureBox1.Width;
            float b = pictureBox1.Height;       
            float c = Planeta.Mapa.Size.Width;
            float d = Planeta.Mapa.Size.Height;

            x.X = (int)(  c *    ((float)x.X  /  a) );
            x.Y = (int)(  d *    ((float)x.Y  /  b) );

            Planeta.aktualizacja_miejsc( x );
            pictureBox1.Image = Planeta.Mapa;

        }

        private void algorytm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorytm2ToolStripMenuItem.Checked = false;
            algorytm3ToolStripMenuItem.Checked = false;
        }

        private void algorytm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorytm1ToolStripMenuItem.Checked = false;
            algorytm3ToolStripMenuItem.Checked = false;
        }

        private void algorytm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorytm1ToolStripMenuItem.Checked = false;
            algorytm2ToolStripMenuItem.Checked = false;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wierzcholkiButton.Enabled = true;
            grafButton.Enabled = false;

            Planeta = new swiat();
            pictureBox1.Image = Planeta.Oryginal;
        }

        private void liczbaWierzcholkow_Scroll(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uruchomAlgorytmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            uruchomAlgorytmToolStripMenuItem.Enabled = false;
            List<int> Sciezka = new List<int>();

            // Wybor algorytmu, domyslnie pierwszy sie uruchamia
            if (algorytm1ToolStripMenuItem.Checked)
                Sciezka = Al1.Uruchom(Planeta.Wierzcholek);
            else if (algorytm2ToolStripMenuItem.Checked)
                Sciezka = Al2.Uruchom(Planeta.Wierzcholek);
            else if (algorytm3ToolStripMenuItem.Checked)
                Sciezka = Al3.Uruchom(Planeta.Wierzcholek);
            else
                Sciezka = Al1.Uruchom(Planeta.Wierzcholek);

            for (int i = 1; i < Sciezka.Count; i += 1)
                using (var graphics = Graphics.FromImage(Planeta.Mapa))
                { graphics.DrawLine(greenPen, Planeta.Wierzcholek[Sciezka[i - 1]].xy, Planeta.Wierzcholek[Sciezka[i]].xy); }

            pictureBox1.Image = Planeta.Mapa;

        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zakonczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
