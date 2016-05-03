using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zabawa2
{
    public class Pole
    {
        public string Miasto { get; set; }
        public int Cena { get; set; }
        public int NumerPlansza { get; set; }
        public bool Kupione { get; set; }
        public int Ilosc_Domow { get; set; }
        public int Cena_Domu { get; set; }
        public string Wlasciciel { get; set; }
        public int[] PostojOplata = new int[6];

        // pole tablicy
        Pole[] tablica;
        public Pole(int _numer, string _miasto, int _cena, int _cena_domu, int _oplata)
        {
            NumerPlansza = _numer;
            Cena = _cena;
            Miasto = _miasto;
            Kupione = false;
            Ilosc_Domow = 0;
            Cena_Domu = _cena_domu;
            PostojOplata[0] = _oplata;
            for (int i = 1; i < 6; i++)
            {
                    PostojOplata[i] = 5 * i * _oplata;
            }
        }
        public Pole(Pole[] p)
        {
            tablica = p;
        }
        // inicjalizacja obiektow
        public static void Inicjalizacja(Pole[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Pole(p);
            }
        }
    }
}
