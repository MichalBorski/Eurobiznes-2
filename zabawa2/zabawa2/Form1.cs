using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zabawa2
{
    public partial class Form1 : Form
    {
        Pole[] tab_Pol = new Pole[6]; // tablica pol
        Gracz[] tab_Gracze; // tworzymy tablice graczy
        // tu narazie jest zarezerwowana pamiec na zmienna graczy ale nie sa jeszcze oni zainicjalizowani
        int aktualnePole=0;
        int aktualnyGracz = 0;
        public Form1()
        { }

        public Form1(int iloscGraczy, string [] tab_imion)
        {

            InitializeComponent();
            tab_Gracze = new Gracz[iloscGraczy]; // tablica o zadanym rozmiarze
            // otrzymanym od formularze StartUP
            Gracz.Inicjalizacja(tab_Gracze);
            // bez inicjalizacji gubia mi sie te dane o graczach
            Pole.Inicjalizacja(tab_Pol);

            btnRzuc.Enabled = true;
            btnKup.Enabled = false;
            tab_Pol[0] = new Pole(1, "Saloniki", 100, 100, 5);
            tab_Pol[1] = new Pole(2, "Ateny", 120, 100,10);
            tab_Pol[2] = new Pole(3, "Mediolan", 200, 100,10); 
            tab_Pol[3] = new Pole(4, "Rzym", 240 , 100, 20);
            tab_Pol[4] = new Pole(5, "Sewila", 300, 200, 25);
            tab_Pol[5] = new Pole(6, "Madryt", 340, 200, 30);

            for (int i=0 ; i<iloscGraczy; i++)
            {
                tab_Gracze[i] = new Gracz(i+1, tab_imion[i]); // korzystamy z konstruktora
                // ktory bierze numer chyba id i imie
                MessageBox.Show("Gracz " + (i + 1) + " o imieniu: " + tab_imion[i]);
            }
            
            lbKasaShow.Text = tab_Gracze[aktualnyGracz].Kasa.ToString();
            lbImieShow.Text = tab_Gracze[aktualnyGracz].Name;
            btnBuduj.Enabled = false;
            btnOkAcceptIloscDomy.Enabled = false;
        }
        private int GetNumberOfPlayers()
        {
            return tab_Gracze.Length;
        }

        private void btnRzuc_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int r = x.Next(1, 6); // od obiektu klasy Random
            txtResult.Text = r.ToString();
            
            aktualnePole += r;
            if (aktualnePole > 6)  // zalezne od liczby pol
                aktualnePole -= 6;
           // pokazanie aktualnego pola na ktorym stoimy
            lbMiastoShow.Text = tab_Pol[aktualnePole-1].Miasto;
            lbCenaShow.Text = tab_Pol[aktualnePole-1].Cena.ToString();
            lbNumerShow.Text = tab_Pol[aktualnePole-1].NumerPlansza.ToString();
            lbWlascicielShow.Text = tab_Pol[aktualnePole - 1].Wlasciciel;

            foreach (Pole szukajPole in tab_Gracze[aktualnyGracz].lista_nieruchomosci)
            {
                if (szukajPole.Miasto != null)
                    lstNieruchomosci.Items.Add(szukajPole.Miasto + " (" + szukajPole.Ilosc_Domow + ") ");
            }
            // sprawdzanie POSTOJU U PRZECIWNIKA
           
            // DRUGI SPOSOB  -- dziala :)
            int Oplata = tab_Pol[aktualnePole - 1].PostojOplata[tab_Pol[aktualnePole - 1].Ilosc_Domow];
            if(tab_Gracze[aktualnyGracz].Name != tab_Pol[aktualnePole -1].Wlasciciel)
            {
                MessageBox.Show("To pole nie jest Twoje");
                if (lbWlascicielShow.Text != "")
                {
                    MessageBox.Show("To pole ma własiciela");
                    foreach(Gracz szukajGracz in tab_Gracze)
                    {
                        if(szukajGracz.Name == tab_Pol[aktualnePole-1].Wlasciciel)
                        {
                            MessageBox.Show("Znalazlem wlasciciela. Przekazuje mu ( "
                                +szukajGracz.Name+" ) " + Oplata);
                            szukajGracz.Kasa += Oplata;
                            tab_Gracze[aktualnyGracz].Kasa -= Oplata;
                        }
                    }                   
                }
                else if (lbWlascicielShow.Text == "")
                {
                    MessageBox.Show("To pole nie ma wlasciciela");
                }

            }
            // update kasy
            lbKasaShow.Text = tab_Gracze[aktualnyGracz].Kasa.ToString();

            btnKup.Enabled = true;
            btnRzuc.Enabled = false;
            btnBuduj.Enabled = false;
            btnOkAcceptIloscDomy.Enabled = true;
   
        }
        private void btnKup_Click(object sender, EventArgs e)
        {
            tab_Gracze[aktualnyGracz].kupowanie_lista(tab_Pol, aktualnePole - 1, aktualnyGracz, tab_Gracze); //dodawanie elementu do listy
            lbKasaShow.Text = tab_Gracze[aktualnyGracz].Kasa.ToString();

            lstNieruchomosci.Items.Clear();
            foreach (Pole szukajPole in tab_Gracze[aktualnyGracz].lista_nieruchomosci)
            {
                if (szukajPole.Miasto != null)
                    lstNieruchomosci.Items.Add(szukajPole.Miasto + " (" + szukajPole.Ilosc_Domow + ") ");
            }
            lbWlascicielShow.Text = tab_Pol[aktualnePole - 1].Wlasciciel;
            btnKup.Enabled = false;
            
        }

        public class Gracz
        {
            public int Kasa { get; set; }
            public int ID { get; set; }
            public string Name { get; set; }
            public List<Pole> lista_nieruchomosci = new List<Pole>();
            Gracz[] tablica; // mógłbym to chyba pyknąć na liste graczy?
            public Gracz()
            {

            }
            // potrzebujemy miec to by sobie utworzyc tablice nizej
            public Gracz(Gracz[] g) // dostaje jako artument tablice graczy
            {
                tablica = g; /// przypisujemy do pola nasze tablicy , tablice z konstrukotra
            }
            public Gracz (int _id, string _name)
            {
                ID = _id;
                Name = _name;
                Kasa = 1000;
            }

            public static void Inicjalizacja(Gracz[] g)
            {
                for (int i = 0; i < g.Length; i++)
                {
                    g[i] = new Gracz(g); // korzystamy z kontruktora ktory dostaje tablice
                }
            }
            public void kupowanie_lista(Pole [] p, int aktualnePole, int aktualnyGracz, Gracz [] tab_Gracze)
            {
                // inaczej - sprawdzanie czy taki obiekt istnieje na liscie
                string sMiasto = p[aktualnePole].Miasto;
                bool bExist = lista_nieruchomosci.Exists(oElement => oElement.Miasto.Equals(sMiasto));
   
                if (bExist || p[aktualnePole].Kupione)
                {
                    MessageBox.Show("Nieruchomość jest już kupiona");

                }
                else
                {
                    if (aktualnePole != 0)
                    {
                        tab_Gracze[aktualnyGracz].Kasa -= p[aktualnePole].Cena;
                    }
                    p[aktualnePole].Kupione = true;
                    lista_nieruchomosci.Add(p[aktualnePole]);
                    p[aktualnePole].Wlasciciel = tab_Gracze[aktualnyGracz].Name;
                   
                }
                
            }
        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            btnRzuc.Enabled = true;
            lbKasaShow.Text = null;
            lbImieShow.Text = null;
            aktualnyGracz++;
            if (aktualnyGracz >= GetNumberOfPlayers())
                aktualnyGracz = 0;

            lbKasaShow.Text = tab_Gracze[aktualnyGracz].Kasa.ToString();
            lbImieShow.Text = tab_Gracze[aktualnyGracz].Name;
            lstNieruchomosci.Items.Clear();
            
            btnKup.Enabled = false;
        }

        private void btnOkAcceptIloscDomy_Click(object sender, EventArgs e)
        {
            int _iloscDomow=0;
            int MaxLeftDomy = 5;
            if(txtInputIloscDomow.Text != "")
            {
                bool iloscDomowUdane = int.TryParse(txtInputIloscDomow.Text, out _iloscDomow);
                if (iloscDomowUdane)
                {
                    if (_iloscDomow <= MaxLeftDomy)
                    {
                        lbCenaDomyShow.Text = (_iloscDomow * tab_Pol[aktualnePole - 1].Cena_Domu).ToString();
                        MaxLeftDomy -= _iloscDomow;
                    }
                    else
                        MessageBox.Show("Nie mozna zbudowac tak duzej liczby domow");
                }
                else
                {
                    MessageBox.Show("Niepoprawna ilosc domow");
                    txtInputIloscDomow.Text = "";
                }             
            }            
            btnBuduj.Enabled = true;

        }

        private void btnBuduj_Click(object sender, EventArgs e)
        {
 
            int CalyKosztBudowy;
            int IloscDomow;
            lstNieruchomosci.Items.Clear();
            foreach(Pole szukajPole in tab_Gracze[aktualnyGracz].lista_nieruchomosci)
            {
                if(szukajPole.NumerPlansza == tab_Pol[aktualnePole-1].NumerPlansza)
                {
                    
                    if(lbCenaDomyShow.Text != "")
                    {
                        CalyKosztBudowy = int.Parse(lbCenaDomyShow.Text);
                        tab_Gracze[aktualnyGracz].Kasa -= CalyKosztBudowy;
                    }

                    if(txtInputIloscDomow.Text != "")
                    {
                        IloscDomow = int.Parse(txtInputIloscDomow.Text);
                        if(tab_Pol[aktualnePole-1].Ilosc_Domow + IloscDomow <= 5)
                        {
                            tab_Pol[aktualnePole-1].Ilosc_Domow += IloscDomow;
                            MessageBox.Show("Mozna budowac, to nalezy do tego gracza");
                        }
                        else
                            MessageBox.Show("Nie mozna zbudowac tak duzo domow");
                                                
                    }
                    // pokazanie kasy
                    lbKasaShow.Text = tab_Gracze[aktualnyGracz].Kasa.ToString();
                }

                else if (szukajPole.NumerPlansza != tab_Pol[aktualnePole-1].NumerPlansza)
                {
                    MessageBox.Show("Nie mozesz tu budować, to nie nalezy do Ciebie");
                }
     
            }
                //wyswietlanie razem z iloscia domow
                foreach (Pole _szukajPole in tab_Gracze[aktualnyGracz].lista_nieruchomosci)
                {
                    if (_szukajPole.Miasto != null)
                        lstNieruchomosci.Items.Add(_szukajPole.Miasto + " (" + _szukajPole.Ilosc_Domow + ") ");
                }
                //reset wrzuconych wartosci, aby wpisac od nowa
                txtInputIloscDomow.Text = null;
                lbCenaDomyShow.Text = null;

        }

        private void btnKogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To pole nalezy do: " + tab_Pol[aktualnePole-1].Wlasciciel + "\n"+
                tab_Pol[aktualnePole-1].PostojOplata[tab_Pol[aktualnePole-1].Ilosc_Domow]);
        }
        private void PostojUPrzeciwnika()
        {
            foreach (Pole szukajPole in tab_Gracze[aktualnyGracz].lista_nieruchomosci)
            {
                if (szukajPole.NumerPlansza != tab_Pol[aktualnePole - 1].NumerPlansza)
                {
                    MessageBox.Show("To nie jest Twoje pole, możliwe że trzeba zaplacic");
                }
            }
        }




    }
}
