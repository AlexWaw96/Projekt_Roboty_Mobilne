using System;
using System.Drawing;


/// <summary>
/// PLANETA NASZA TO JEST
/// Tu zawiera sie cala informacja o swiecie
/// </summary>

namespace Przeszukiwanie_grafu
{
    enum Stan_poz { Brak_punktow = 0, Jeden_punkt = 1, Dwa_Wierzcholek = 2 };

    class swiat
    {
        public Stan_poz Stan_pozycji;  // Maszyna stanow do wyboru pozycji

        public Point Pozycja_startowa; // Pozycja startowa algorytmu
        public Point Pozycja_Koncowa;  // Pozycja Koncowa algorytmu
        
        public Bitmap Oryginal;        // Wczytana bitmapa ze zmianami
        public Bitmap Mapa;            // Oryginalna bitmapa sluzaca do podmianki

        Rysowanie Rysuj = new Rysowanie();
        Metody_Pomocnicze Pomocne_Metody;

        Pen blackPen = new Pen(Color.Black, 3);
        Pen bluePen = new Pen(Color.Blue, 3);
        Pen greenPen = new Pen(Color.Green, 13);

        public int Liczba_Wierzcholkow;
        int Graf_odl_x;                 // Co ile x pixeli sa umieszczone wierzcholki
        int Graf_odl_y;                 // Co ile y pixeli sa umieszczone punkty
        double Graf_odl_xy;

        public int wybor_Al;
        public wierzcholek[] Wierzcholek;

        public swiat()
        {
            Pomocne_Metody = new Metody_Pomocnicze();
            Pozycja_startowa = new Point(3049, 793);
            Pozycja_Koncowa = new Point(1802, 561);
            aktualizuj_oryginal(new Bitmap(@"..\..\mapa.png"));
            aktualizuj_mape(new Bitmap(@"..\..\mapa.png"));
          
            Liczba_Wierzcholkow = 2;
            Stan_pozycji = Stan_poz.Brak_punktow;
            wybor_Al = 1;
        }

        #region Metody
        /// <summary>
        /// Tworzy wierzcholki grafu
        /// </summary>
        /// <param name="st_wypelnienia"> Okresla co ile % pixela jest wierzcholek</param>
        public void Generuj_Wierzcholek(int st_wypelnienia)
        {
            int X = Mapa.Width;
            int Y = Mapa.Height;

            if (st_wypelnienia == 1000)
                st_wypelnienia = 999;

            float st_w = st_wypelnienia / 10;

            Graf_odl_y =(int) ( (100 - st_w) * (Y / 100) );
            Graf_odl_x =(int) ( (100 - st_w) * (X / 100) );

            int ile = (int)(  (Y/ Graf_odl_y  -1)  *( X/ Graf_odl_x  -1)  ) +1;
            Wierzcholek = new wierzcholek[ile + 2];

            Graf_odl_xy = Math.Sqrt( (Graf_odl_x*Graf_odl_x) + (Graf_odl_y * Graf_odl_y) );

            Wierzcholek[0] = new wierzcholek();
            Wierzcholek[1] = new wierzcholek();
            Wierzcholek[0].xy = Pozycja_startowa; Wierzcholek[0].nr = 0;
            Wierzcholek[1].xy = Pozycja_Koncowa;  Wierzcholek[1].nr = 1;

            Liczba_Wierzcholkow = 2;
            Color a = Color.FromArgb(0, 255, 255, 255);

            for    (int i = 3; i<Y; i += Graf_odl_y)
                for(int k = 3; k<X; k += Graf_odl_x) { 
                    if (Mapa.GetPixel(k, i) == a) {
                        Wierzcholek[Liczba_Wierzcholkow] = new wierzcholek();
                        Wierzcholek[Liczba_Wierzcholkow].xy = new Point(k, i);
                        Mapa = Rysuj.kropka(Mapa, Wierzcholek[Liczba_Wierzcholkow].xy);
                        Wierzcholek[Liczba_Wierzcholkow].nr = Liczba_Wierzcholkow;

                        Liczba_Wierzcholkow++;
                    }    
                }
        }

        /// <summary>
        /// Tworzy graf z danych wierzcholkow
        /// </summary>
        public void Stworz_graf()
        {
            int i;
            int j;

            // Ustalenie kto ma jakiego sasiada
            for (i = 0; i < Liczba_Wierzcholkow; i++)
                for (j = 0; j < Liczba_Wierzcholkow ; j++){
                    if (i != j){
                        Point o = Wierzcholek[i].xy;
                        Point z = Wierzcholek[j].xy;
                        
                        if (!Wierzcholek[i].sasiedzi.Contains(j))
                        {
                            double odl = Pomocne_Metody.Odleglosc(o, z);
                            if (odl <= Graf_odl_xy)
                            {
                                Wierzcholek[i].sasiedzi.Add(j);
                                Wierzcholek[j].sasiedzi.Add(i);
                                Wierzcholek[i].sasiedzi_odl.Add(odl);
                                Wierzcholek[j].sasiedzi_odl.Add(odl);
                            }
                        }
                    }
                   
                }

            // Narysowanie kresek
            for (i = 0; i < Liczba_Wierzcholkow; i++) {

                int liczba_sasiadow = Wierzcholek[i].sasiedzi.Count;

                for (j = 0; j < liczba_sasiadow; j++) {
                    using (var graphics = Graphics.FromImage(Mapa))
                    {
                        graphics.DrawLine(blackPen, Wierzcholek[i].xy, Wierzcholek[ Wierzcholek[i].sasiedzi[j]  ].xy);
                    }

                 }
             }


        }

        public void aktualizuj_mape(Bitmap x) {  Oryginal = x; }
        public void aktualizuj_oryginal(Bitmap x) { Mapa = x; }

        public  void aktualizacja_miejsc(Point x){

            switch (Stan_pozycji){
                case Stan_poz.Brak_punktow:

                    Pozycja_startowa.X = x.X;
                    Pozycja_startowa.Y = x.Y;
                    Stan_pozycji = Stan_poz.Jeden_punkt;
                    Rysuj.kropka(Mapa, Pozycja_startowa, 8);
                    break;

                case Stan_poz.Jeden_punkt:

                    Pozycja_Koncowa.X = x.X;
                    Pozycja_Koncowa.Y = x.Y;
                    Stan_pozycji = Stan_poz.Dwa_Wierzcholek;
                    Rysuj.kropka(Mapa, Pozycja_Koncowa, 8);
                    break;

                case Stan_poz.Dwa_Wierzcholek:

                    Pozycja_startowa.X = -1;
                    Pozycja_startowa.Y = -1;
                    Pozycja_Koncowa.X = -1;
                    Pozycja_Koncowa.Y = -1;
                    Stan_pozycji = Stan_poz.Brak_punktow;
                    Mapa = Oryginal;
                    break;

                default:

                    break;

            }
        }
        public bool Spr_konca(int x, int y, int offset){

            if ((x < Pozycja_Koncowa.X + offset && x > Pozycja_Koncowa.X - offset) && (y > Pozycja_Koncowa.Y - offset && y < Pozycja_Koncowa.Y + offset))
                return true;
            else
                return false;
        }

        public bool Spr_czy_lad(Point poczatek, Point koniec){

            int xSr = (poczatek.X + koniec.X) / 2;
            int ySr = (poczatek.Y + koniec.Y) / 2;

            if (Oryginal.GetPixel(xSr, ySr) != Oryginal.GetPixel(5, 10)) return true;
            else                                                         return false;

        }

        #endregion

    }
}
