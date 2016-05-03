namespace zabawa2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRzuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKup = new System.Windows.Forms.Button();
            this.lbImie = new System.Windows.Forms.Label();
            this.lbKasa = new System.Windows.Forms.Label();
            this.lbImieShow = new System.Windows.Forms.Label();
            this.lbKasaShow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumer = new System.Windows.Forms.Label();
            this.lbMiasto = new System.Windows.Forms.Label();
            this.lbCena = new System.Windows.Forms.Label();
            this.lbNumerShow = new System.Windows.Forms.Label();
            this.lbMiastoShow = new System.Windows.Forms.Label();
            this.lbCenaShow = new System.Windows.Forms.Label();
            this.lbPosiadlosci = new System.Windows.Forms.Label();
            this.btnNextPlayer = new System.Windows.Forms.Button();
            this.lstNieruchomosci = new System.Windows.Forms.ListBox();
            this.btnBuduj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIlosc = new System.Windows.Forms.Label();
            this.txtInputIloscDomow = new System.Windows.Forms.TextBox();
            this.lbCenaDomy = new System.Windows.Forms.Label();
            this.lbCenaDomyShow = new System.Windows.Forms.Label();
            this.btnOkAcceptIloscDomy = new System.Windows.Forms.Button();
            this.btnKogo = new System.Windows.Forms.Button();
            this.lbWlasciciel = new System.Windows.Forms.Label();
            this.lbWlascicielShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(99, 229);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(43, 20);
            this.txtResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wyrzuciles: ";
            // 
            // btnRzuc
            // 
            this.btnRzuc.Location = new System.Drawing.Point(32, 255);
            this.btnRzuc.Name = "btnRzuc";
            this.btnRzuc.Size = new System.Drawing.Size(84, 34);
            this.btnRzuc.TabIndex = 2;
            this.btnRzuc.Text = "Rzuc";
            this.btnRzuc.UseVisualStyleBackColor = true;
            this.btnRzuc.Click += new System.EventHandler(this.btnRzuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dane Gracza";
            // 
            // btnKup
            // 
            this.btnKup.Location = new System.Drawing.Point(261, 175);
            this.btnKup.Name = "btnKup";
            this.btnKup.Size = new System.Drawing.Size(77, 33);
            this.btnKup.TabIndex = 4;
            this.btnKup.Text = "kup";
            this.btnKup.UseVisualStyleBackColor = true;
            this.btnKup.Click += new System.EventHandler(this.btnKup_Click);
            // 
            // lbImie
            // 
            this.lbImie.AutoSize = true;
            this.lbImie.Location = new System.Drawing.Point(29, 45);
            this.lbImie.Name = "lbImie";
            this.lbImie.Size = new System.Drawing.Size(26, 13);
            this.lbImie.TabIndex = 5;
            this.lbImie.Text = "Imie";
            // 
            // lbKasa
            // 
            this.lbKasa.AutoSize = true;
            this.lbKasa.Location = new System.Drawing.Point(29, 70);
            this.lbKasa.Name = "lbKasa";
            this.lbKasa.Size = new System.Drawing.Size(31, 13);
            this.lbKasa.TabIndex = 6;
            this.lbKasa.Text = "Kasa";
            // 
            // lbImieShow
            // 
            this.lbImieShow.AutoSize = true;
            this.lbImieShow.Location = new System.Drawing.Point(63, 45);
            this.lbImieShow.Name = "lbImieShow";
            this.lbImieShow.Size = new System.Drawing.Size(37, 13);
            this.lbImieShow.TabIndex = 11;
            this.lbImieShow.Text = "_____";
            // 
            // lbKasaShow
            // 
            this.lbKasaShow.AutoSize = true;
            this.lbKasaShow.Location = new System.Drawing.Point(63, 70);
            this.lbKasaShow.Name = "lbKasaShow";
            this.lbKasaShow.Size = new System.Drawing.Size(37, 13);
            this.lbKasaShow.TabIndex = 13;
            this.lbKasaShow.Text = "_____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(258, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nieruchomość";
            // 
            // lbNumer
            // 
            this.lbNumer.AutoSize = true;
            this.lbNumer.Location = new System.Drawing.Point(233, 61);
            this.lbNumer.Name = "lbNumer";
            this.lbNumer.Size = new System.Drawing.Size(62, 13);
            this.lbNumer.TabIndex = 15;
            this.lbNumer.Text = "Numer Pola";
            // 
            // lbMiasto
            // 
            this.lbMiasto.AutoSize = true;
            this.lbMiasto.Location = new System.Drawing.Point(233, 86);
            this.lbMiasto.Name = "lbMiasto";
            this.lbMiasto.Size = new System.Drawing.Size(40, 13);
            this.lbMiasto.TabIndex = 16;
            this.lbMiasto.Text = "Nazwa";
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.Location = new System.Drawing.Point(233, 112);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(32, 13);
            this.lbCena.TabIndex = 17;
            this.lbCena.Text = "Cena";
            // 
            // lbNumerShow
            // 
            this.lbNumerShow.AutoSize = true;
            this.lbNumerShow.Location = new System.Drawing.Point(301, 61);
            this.lbNumerShow.Name = "lbNumerShow";
            this.lbNumerShow.Size = new System.Drawing.Size(37, 13);
            this.lbNumerShow.TabIndex = 18;
            this.lbNumerShow.Text = "_____";
            // 
            // lbMiastoShow
            // 
            this.lbMiastoShow.AutoSize = true;
            this.lbMiastoShow.Location = new System.Drawing.Point(301, 86);
            this.lbMiastoShow.Name = "lbMiastoShow";
            this.lbMiastoShow.Size = new System.Drawing.Size(37, 13);
            this.lbMiastoShow.TabIndex = 19;
            this.lbMiastoShow.Text = "_____";
            // 
            // lbCenaShow
            // 
            this.lbCenaShow.AutoSize = true;
            this.lbCenaShow.Location = new System.Drawing.Point(301, 112);
            this.lbCenaShow.Name = "lbCenaShow";
            this.lbCenaShow.Size = new System.Drawing.Size(37, 13);
            this.lbCenaShow.TabIndex = 20;
            this.lbCenaShow.Text = "_____";
            // 
            // lbPosiadlosci
            // 
            this.lbPosiadlosci.AutoSize = true;
            this.lbPosiadlosci.Location = new System.Drawing.Point(29, 96);
            this.lbPosiadlosci.Name = "lbPosiadlosci";
            this.lbPosiadlosci.Size = new System.Drawing.Size(103, 13);
            this.lbPosiadlosci.TabIndex = 21;
            this.lbPosiadlosci.Text = "Posiadlosci (domy) : ";
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.Location = new System.Drawing.Point(236, 255);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(117, 31);
            this.btnNextPlayer.TabIndex = 24;
            this.btnNextPlayer.Text = "Następny Gracz";
            this.btnNextPlayer.UseVisualStyleBackColor = true;
            this.btnNextPlayer.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // lstNieruchomosci
            // 
            this.lstNieruchomosci.FormattingEnabled = true;
            this.lstNieruchomosci.Location = new System.Drawing.Point(32, 126);
            this.lstNieruchomosci.Name = "lstNieruchomosci";
            this.lstNieruchomosci.Size = new System.Drawing.Size(121, 82);
            this.lstNieruchomosci.TabIndex = 25;
            // 
            // btnBuduj
            // 
            this.btnBuduj.Location = new System.Drawing.Point(395, 175);
            this.btnBuduj.Name = "btnBuduj";
            this.btnBuduj.Size = new System.Drawing.Size(78, 32);
            this.btnBuduj.TabIndex = 26;
            this.btnBuduj.Text = "Buduj";
            this.btnBuduj.UseVisualStyleBackColor = true;
            this.btnBuduj.Click += new System.EventHandler(this.btnBuduj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(392, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Zbuduj domy";
            // 
            // lbIlosc
            // 
            this.lbIlosc.AutoSize = true;
            this.lbIlosc.Location = new System.Drawing.Point(392, 90);
            this.lbIlosc.Name = "lbIlosc";
            this.lbIlosc.Size = new System.Drawing.Size(29, 13);
            this.lbIlosc.TabIndex = 28;
            this.lbIlosc.Text = "Ilość";
            // 
            // txtInputIloscDomow
            // 
            this.txtInputIloscDomow.Location = new System.Drawing.Point(439, 87);
            this.txtInputIloscDomow.Name = "txtInputIloscDomow";
            this.txtInputIloscDomow.Size = new System.Drawing.Size(39, 20);
            this.txtInputIloscDomow.TabIndex = 29;
            // 
            // lbCenaDomy
            // 
            this.lbCenaDomy.AutoSize = true;
            this.lbCenaDomy.Location = new System.Drawing.Point(392, 115);
            this.lbCenaDomy.Name = "lbCenaDomy";
            this.lbCenaDomy.Size = new System.Drawing.Size(38, 13);
            this.lbCenaDomy.TabIndex = 30;
            this.lbCenaDomy.Text = "Cena: ";
            // 
            // lbCenaDomyShow
            // 
            this.lbCenaDomyShow.AutoSize = true;
            this.lbCenaDomyShow.Location = new System.Drawing.Point(436, 115);
            this.lbCenaDomyShow.Name = "lbCenaDomyShow";
            this.lbCenaDomyShow.Size = new System.Drawing.Size(19, 13);
            this.lbCenaDomyShow.TabIndex = 31;
            this.lbCenaDomyShow.Text = "__";
            // 
            // btnOkAcceptIloscDomy
            // 
            this.btnOkAcceptIloscDomy.Location = new System.Drawing.Point(496, 84);
            this.btnOkAcceptIloscDomy.Name = "btnOkAcceptIloscDomy";
            this.btnOkAcceptIloscDomy.Size = new System.Drawing.Size(31, 25);
            this.btnOkAcceptIloscDomy.TabIndex = 32;
            this.btnOkAcceptIloscDomy.Text = "OK";
            this.btnOkAcceptIloscDomy.UseVisualStyleBackColor = true;
            this.btnOkAcceptIloscDomy.Click += new System.EventHandler(this.btnOkAcceptIloscDomy_Click);
            // 
            // btnKogo
            // 
            this.btnKogo.Location = new System.Drawing.Point(261, 215);
            this.btnKogo.Name = "btnKogo";
            this.btnKogo.Size = new System.Drawing.Size(102, 23);
            this.btnKogo.TabIndex = 33;
            this.btnKogo.Text = "Kogo/Oplata";
            this.btnKogo.UseVisualStyleBackColor = true;
            this.btnKogo.Click += new System.EventHandler(this.btnKogo_Click);
            // 
            // lbWlasciciel
            // 
            this.lbWlasciciel.AutoSize = true;
            this.lbWlasciciel.Location = new System.Drawing.Point(233, 135);
            this.lbWlasciciel.Name = "lbWlasciciel";
            this.lbWlasciciel.Size = new System.Drawing.Size(57, 13);
            this.lbWlasciciel.TabIndex = 34;
            this.lbWlasciciel.Text = "Właściciel";
            // 
            // lbWlascicielShow
            // 
            this.lbWlascicielShow.AutoSize = true;
            this.lbWlascicielShow.Location = new System.Drawing.Point(301, 135);
            this.lbWlascicielShow.Name = "lbWlascicielShow";
            this.lbWlascicielShow.Size = new System.Drawing.Size(37, 13);
            this.lbWlascicielShow.TabIndex = 35;
            this.lbWlascicielShow.Text = "_____";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 340);
            this.Controls.Add(this.lbWlascicielShow);
            this.Controls.Add(this.lbWlasciciel);
            this.Controls.Add(this.btnKogo);
            this.Controls.Add(this.btnOkAcceptIloscDomy);
            this.Controls.Add(this.lbCenaDomyShow);
            this.Controls.Add(this.lbCenaDomy);
            this.Controls.Add(this.txtInputIloscDomow);
            this.Controls.Add(this.lbIlosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuduj);
            this.Controls.Add(this.lstNieruchomosci);
            this.Controls.Add(this.btnNextPlayer);
            this.Controls.Add(this.lbPosiadlosci);
            this.Controls.Add(this.lbCenaShow);
            this.Controls.Add(this.lbMiastoShow);
            this.Controls.Add(this.lbNumerShow);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.lbMiasto);
            this.Controls.Add(this.lbNumer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbKasaShow);
            this.Controls.Add(this.lbImieShow);
            this.Controls.Add(this.lbKasa);
            this.Controls.Add(this.lbImie);
            this.Controls.Add(this.btnKup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRzuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRzuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKup;
        private System.Windows.Forms.Label lbImie;
        private System.Windows.Forms.Label lbKasa;
        private System.Windows.Forms.Label lbImieShow;
        private System.Windows.Forms.Label lbKasaShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNumer;
        private System.Windows.Forms.Label lbMiasto;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.Label lbNumerShow;
        private System.Windows.Forms.Label lbMiastoShow;
        private System.Windows.Forms.Label lbCenaShow;
        private System.Windows.Forms.Label lbPosiadlosci;
        private System.Windows.Forms.Button btnNextPlayer;
        private System.Windows.Forms.ListBox lstNieruchomosci;
        private System.Windows.Forms.Button btnBuduj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIlosc;
        private System.Windows.Forms.TextBox txtInputIloscDomow;
        private System.Windows.Forms.Label lbCenaDomy;
        private System.Windows.Forms.Label lbCenaDomyShow;
        private System.Windows.Forms.Button btnOkAcceptIloscDomy;
        private System.Windows.Forms.Button btnKogo;
        private System.Windows.Forms.Label lbWlasciciel;
        private System.Windows.Forms.Label lbWlascicielShow;
    }
}

