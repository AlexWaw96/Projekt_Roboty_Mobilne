using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Przeszukiwanie_grafu
{
    class Algorytm3
    {

        Metody_Pomocnicze PM;

        public Algorytm3()
        {
            PM = new Metody_Pomocnicze();
        }
        /// <summary>
        ///  Best-first search algorytm
        /// </summary>
        /// <param name="W"></param>
        /// <returns></returns>
        public List<int> Uruchom(wierzcholek[] W)
        {
            W[0].Odwiedzony = true;
            W[0].Dr_do_pkt = 0;

            int aktualny = 0;
            int i;
            List<int> Sciezka = new List<int>();
            List<int> Otwarte = new List<int>();

            Point koncowy = W[1].xy;

            while (!W[1].Odwiedzony)
            {

                // Dla wszystkich nieodwiedzonych sasiadow dodaj ich do listy otwartych
                int Liczba_sasiadow = W[aktualny].sasiedzi.Count;


                for (i = 0; i < Liczba_sasiadow; i++)
                {
                    int nr_sasiada = W[aktualny].sasiedzi[i];

                    //Jesli nieodwiedzony to go dodajemy
                    if (!W[nr_sasiada].Odwiedzony)
                    {
                        // Jesli nie jest juz w liscie to go dodajemy
                        if (!Otwarte.Contains(nr_sasiada))
                        {
                            Otwarte.Add(nr_sasiada);
                        }

                        // Sasiad ma droge dojscia rowna swemu poprzednikowi i aktualnej odleglosci miedzy nimi
                        double odl = W[aktualny].Dr_do_pkt + W[aktualny].sasiedzi_odl[i];

                        if ((odl < W[nr_sasiada].Dr_do_pkt) || W[nr_sasiada].Dr_do_pkt == -1)
                            W[nr_sasiada].Dr_do_pkt = W[aktualny].Dr_do_pkt + W[aktualny].sasiedzi_odl[i];

                    }

                }

                // Teraz sprawdzamy do ktorego elementu z listy otwartych cisniemy
                int ktory_blizej = -1;
                double aktualna_odl = 100000; //jakas duzo wartosc by mogl sie cofac

                for (i = 0; i < Otwarte.Count; i++)
                {

                    double odl = PM.Odleglosc(W[Otwarte[i]].xy, koncowy) ;
                    if (odl < aktualna_odl)
                    {
                        aktualna_odl = odl;
                        ktory_blizej = Otwarte[i];
                    }
                }

                // Do tego przechodzimy lub koniec jezeli nie da sie dojsc
                if (ktory_blizej != -1)
                {
                    aktualny = ktory_blizej;
                    W[aktualny].Odwiedzony = true;
                    Otwarte.Remove(aktualny);
                }
                else { break; }

            }

            //Rekonstrukcja sciezki po kosztach dojscia
            int powrot = 1;
            Sciezka.Add(powrot);

            while (powrot != 0)
            {
                double wartosc = 1000000;
                int wybor_sasiada = -1;
                int L_sasiado = W[powrot].sasiedzi.Count;
                for (i = 0; i < L_sasiado; i++)
                {
                    int nr = W[powrot].sasiedzi[i];

                    if (W[nr].Odwiedzony)
                        if (W[nr].Dr_do_pkt + W[powrot].sasiedzi_odl[i] < wartosc)
                        {
                            wartosc = W[nr].Dr_do_pkt + W[powrot].sasiedzi_odl[i];
                            wybor_sasiada = nr;
                        }

                }

                if (wybor_sasiada == -1)
                    break;
                powrot = wybor_sasiada;
                Sciezka.Add(powrot);

            }



            return Sciezka;
        }
    }
}
