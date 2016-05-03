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
    public partial class StartUp : Form
    {
        int ilosc_graczy = 0;
        // trzeba utworzyc tablice stringow na przechowywanie imion
        string[] tabImiona = new string [4];
        public StartUp()
        {
            InitializeComponent();

            btnOK.Visible = false;
            lbImie_1.Visible = false;
            txtImieInput.Visible = false;
            txtImieInput2.Visible = false;
            lbImie_2.Visible = false;
            btnOK_2.Visible = false;
            btnOK_3.Visible = false;
            txtImieInput3.Visible = false;
            lb_Imie3.Visible = false;
            btnOK_4.Visible = false;
            lb_Imie4.Visible = false;
            txtImieInput4.Visible = false;

            btnRozpocznij.Enabled = false;


        }

        private void btnPobierzLiczbe_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsIloscGraczyConversionSuccessful = Int32.TryParse(txtGraczeInput.Text, out ilosc_graczy);
                if(IsIloscGraczyConversionSuccessful)
                {
                    if(ilosc_graczy >1 && ilosc_graczy < 5)
                    {
                        btnOK.Visible = true;
                        lbImie_1.Visible = true;
                        txtImieInput.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Wprowdziłeś nieprawidłową liczbę graczy");
                        txtGraczeInput.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show("Nieudana konwersja liczby graczy");
                    txtGraczeInput.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd. :"+ex.Message);
                txtGraczeInput.Text = null;
            }
        }

        private void btnRozpocznij_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(ilosc_graczy, tabImiona);
            f.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UstawGraczy(0, tabImiona, ilosc_graczy, btnOK_2, txtImieInput,
            txtImieInput2, lbImie_2, btnRozpocznij);
        }

        private void btnOK_2_Click(object sender, EventArgs e)
        {
            UstawGraczy(1, tabImiona, ilosc_graczy, btnOK_3,txtImieInput2, 
                        txtImieInput3, lb_Imie3, btnRozpocznij);
            
        }

        private void btnOK_3_Click(object sender, EventArgs e)
        {
            UstawGraczy(2, tabImiona, ilosc_graczy, btnOK_4, txtImieInput3,
            txtImieInput4, lb_Imie4, btnRozpocznij);
        }

        private void btnOK_4_Click(object sender, EventArgs e)
        {
            UstawGraczy(3, tabImiona, ilosc_graczy, btnOK_4, txtImieInput4,
            txtImieInput4, lb_Imie4, btnRozpocznij);

        }

        private static void UstawGraczy(int tabelaIndex, string []tabImiona, int ilosc_graczy, 
            Button btnOK,TextBox txtBox, TextBox txtBoxKolejny, Label lbImie, Button _btnRozpocznij)
        {
            if (txtBox.Text != "")
                tabImiona[tabelaIndex] = txtBox.Text;
            else
                MessageBox.Show("Imie nie moze byc puste");

            if (ilosc_graczy > tabelaIndex + 1 && txtBox.Text != "")
            {
                btnOK.Visible = true;
                lbImie.Visible = true;
                txtBoxKolejny.Visible = true;
            }
            if (ilosc_graczy == tabelaIndex + 1 && txtBox.Text != "")
                _btnRozpocznij.Enabled = true;
        }

    }
}
