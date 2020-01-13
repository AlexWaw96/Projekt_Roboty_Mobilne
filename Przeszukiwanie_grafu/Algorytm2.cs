using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przeszukiwanie_grafu
{
    class Algorytm2
    {

        Metody_Pomocnicze PM;

        public Algorytm2()
        {
            PM = new Metody_Pomocnicze();
        }

        /// <summary>
        /// TO JEST ALGORYTM DJIKSTRY PRZESZUKIWANIA GRAFU
        /// </summary>
        /// <param name="W">Pobiera tylko wierzcholki</param>
        /// <returns>Zwraca Sciezke</returns>
        public List<int> Uruchom(wierzcholek[] W)
        {
            List<int> Sciezka = new List<int>();

            int L_wierzcholkow = W.Length;
            List<int> Q = new List<int>(); // Zbior wierzcholkow do przejscia 
            List<int> S = new List<int>();
            // -1 koszt dojscia to nieskonczonosc, taki jest domyslny w konstruktorze klasy.
            // Poprzednicy tez sa na -1 jako nie zdefiniowani.

            int i = 0;
            // Mamy numery wszystkich wierzcholkow
            for(i=0;i<L_wierzcholkow;i++)
            {
                try { 
                Q.Add(W[i].nr);
                }
                catch
                {
                    break;
                }
            }

            W[0].Dr_do_pkt = 0; // Ustawiamy startowemu wierzcholkowi droge zero dojscia, poniewaz sam do siebie ma 0


            // Wlasciwa czesc algorytmu, wykonujemy dopoki nie skoncza sie wierzcholki lub nie dojdziemy do konca
            while(Q.Count != 0)
            {
                int wyb_nr = 0;
                double droga_dojscia = 10000;

                // Ze wszystkich wierzcholkow wybieramy ten ktory ma najmniejsza droge dojscia
                for (i =0; i<Q.Count; i++)
                {

                    if( W[ Q[i] ].Dr_do_pkt >=0 && W[Q[i]].Dr_do_pkt<droga_dojscia)
                    {
                        wyb_nr = Q[i];
                        droga_dojscia = W[Q[i]].Dr_do_pkt;
                    }

                }

                // Wybrany wierzchołek usuwamy ze zbioru Q i dodajemy do zbioru S.
                Q.Remove(wyb_nr);
                S.Add(wyb_nr);

                //Sprawdzamy jego sasiadow
                int L_sasiadow = W[wyb_nr].sasiedzi.Count;


                // Dla kazdego sasiada ktory ciagle jest w Q aktualizujemy droge dojscia
                for (i = 0; i < L_sasiadow; i++)
                {
                    int nr_somsiada = W[wyb_nr].sasiedzi[i];

                    // Sprawdzamy czy szanowny somsiad jest ciagle w Q 
                    if (Q.Contains(nr_somsiada))
                    {
                        double odl = W[wyb_nr].sasiedzi_odl[i] + W[wyb_nr].Dr_do_pkt;

                        // Sprawdzamy czy odl do sasiada + koszt wlasny jest mniejszy od jego drogi lub wczesniej byl nieosiagalny czyli -1 
                        if ((odl < W[nr_somsiada].Dr_do_pkt) || W[nr_somsiada].Dr_do_pkt == -1)
                        {
                            // Jak tak to nowy koszt dojscia
                            W[nr_somsiada].Dr_do_pkt = odl;
                            // i zapisujemy kto jest jego poprzednikiem

                            W[nr_somsiada].poprzednik = wyb_nr;
                        }
                    }

                }


                // Wczesne przerwanie algorytmu jesli dojdziemy do konca czyli wierzcholek 1 
                if(wyb_nr == 1)
                {
                    break;

                }



            }

            int odtwarzanie = 1;
            // ODtwarzamy po poprzednikach od tylu az dojdziemy do przodu
            Sciezka.Add(odtwarzanie);

            while (odtwarzanie != 0)
            {
                Sciezka.Add(W[odtwarzanie].poprzednik);
                odtwarzanie = W[odtwarzanie].poprzednik;

            }


            return Sciezka;
        }
    }
}
