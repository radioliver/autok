
namespace autok
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label lblKoltsegCim;
        private System.Windows.Forms.Label lblOsszes;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.TextBox tbRendszam;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbModell;
        private System.Windows.Forms.TextBox tbEvjarat;
        private System.Windows.Forms.TextBox tbKm;
        private System.Windows.Forms.TextBox tbKereses;
        private System.Windows.Forms.TextBox tbMegnevezes;
        private System.Windows.Forms.TextBox tbOsszeg;
        private System.Windows.Forms.TextBox tbKoltsegKm;

        private System.Windows.Forms.ComboBox cbUzemanyag;
        private System.Windows.Forms.ComboBox cbSzures;
        private System.Windows.Forms.ComboBox cbKategoria;

        private System.Windows.Forms.DateTimePicker dtDatum;

        private System.Windows.Forms.Button btnAutoFelvetel;
        private System.Windows.Forms.Button btnAutoTorles;
        private System.Windows.Forms.Button btnKoltsegFelvetel;
        private System.Windows.Forms.Button btnKoltsegModositas;
        private System.Windows.Forms.Button btnKoltsegTorles;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnBetoltes;

        private System.Windows.Forms.DataGridView dgvAutok;
        private System.Windows.Forms.DataGridView dgvKoltsegek;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCim = new System.Windows.Forms.Label();
            this.lblKoltsegCim = new System.Windows.Forms.Label();
            this.lblOsszes = new System.Windows.Forms.Label();

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();

            this.tbRendszam = new System.Windows.Forms.TextBox();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModell = new System.Windows.Forms.TextBox();
            this.tbEvjarat = new System.Windows.Forms.TextBox();
            this.tbKm = new System.Windows.Forms.TextBox();
            this.tbKereses = new System.Windows.Forms.TextBox();
            this.tbMegnevezes = new System.Windows.Forms.TextBox();
            this.tbOsszeg = new System.Windows.Forms.TextBox();
            this.tbKoltsegKm = new System.Windows.Forms.TextBox();

            this.cbUzemanyag = new System.Windows.Forms.ComboBox();
            this.cbSzures = new System.Windows.Forms.ComboBox();
            this.cbKategoria = new System.Windows.Forms.ComboBox();

            this.dtDatum = new System.Windows.Forms.DateTimePicker();

            this.btnAutoFelvetel = new System.Windows.Forms.Button();
            this.btnAutoTorles = new System.Windows.Forms.Button();
            this.btnKoltsegFelvetel = new System.Windows.Forms.Button();
            this.btnKoltsegModositas = new System.Windows.Forms.Button();
            this.btnKoltsegTorles = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBetoltes = new System.Windows.Forms.Button();

            this.dgvAutok = new System.Windows.Forms.DataGridView();
            this.dgvKoltsegek = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAutok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoltsegek)).BeginInit();

            this.SuspendLayout();

            // Főcím
            this.lblCim.AutoSize = true;
            this.lblCim.Font = new System.Drawing.Font(
                "Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblCim.Location = new System.Drawing.Point(20, 15);
            this.lblCim.Text = "AUTÓK NYILVÁNTARTÁSA";

            // Autó adatai
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.AutoSize = true;
            this.label1.Text = "Rendszám:";

            this.tbRendszam.Location = new System.Drawing.Point(110, 65);
            this.tbRendszam.Size = new System.Drawing.Size(120, 25);

            this.label2.Location = new System.Drawing.Point(250, 70);
            this.label2.AutoSize = true;
            this.label2.Text = "Márka:";

            this.tbMarka.Location = new System.Drawing.Point(310, 65);
            this.tbMarka.Size = new System.Drawing.Size(120, 25);

            this.label3.Location = new System.Drawing.Point(450, 70);
            this.label3.AutoSize = true;
            this.label3.Text = "Modell:";

            this.tbModell.Location = new System.Drawing.Point(510, 65);
            this.tbModell.Size = new System.Drawing.Size(120, 25);

            this.label4.Location = new System.Drawing.Point(650, 70);
            this.label4.AutoSize = true;
            this.label4.Text = "Évjárat:";

            this.tbEvjarat.Location = new System.Drawing.Point(720, 65);
            this.tbEvjarat.Size = new System.Drawing.Size(80, 25);

            this.label5.Location = new System.Drawing.Point(820, 70);
            this.label5.AutoSize = true;
            this.label5.Text = "Üzemanyag:";

            this.cbUzemanyag.Location = new System.Drawing.Point(920, 65);
            this.cbUzemanyag.Size = new System.Drawing.Size(140, 25);
            this.cbUzemanyag.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUzemanyag.Items.AddRange(new object[]
            {
                "Benzin", "Dízel", "Hibrid",
                "Elektromos", "LPG", "Egyéb"
            });
            this.cbUzemanyag.SelectedIndex = 0;

            this.label6.Location = new System.Drawing.Point(20, 110);
            this.label6.AutoSize = true;
            this.label6.Text = "Kilométer:";

            this.tbKm.Location = new System.Drawing.Point(110, 105);
            this.tbKm.Size = new System.Drawing.Size(120, 25);

            // Autó gombok
            this.btnAutoFelvetel.Location =
                new System.Drawing.Point(250, 105);
            this.btnAutoFelvetel.Size =
                new System.Drawing.Size(140, 30);
            this.btnAutoFelvetel.Text = "Autó felvétele";
            this.btnAutoFelvetel.Click +=
                new System.EventHandler(this.btnAutoFelvetel_Click);

            this.btnAutoTorles.Location =
                new System.Drawing.Point(400, 105);
            this.btnAutoTorles.Size =
                new System.Drawing.Size(140, 30);
            this.btnAutoTorles.Text = "Autó törlése";
            this.btnAutoTorles.Click +=
                new System.EventHandler(this.btnAutoTorles_Click);

            this.btnMentes.Location =
                new System.Drawing.Point(550, 105);
            this.btnMentes.Size =
                new System.Drawing.Size(100, 30);
            this.btnMentes.Text = "Mentés";
            this.btnMentes.Click +=
                new System.EventHandler(this.btnMentes_Click);

            this.btnBetoltes.Location =
                new System.Drawing.Point(660, 105);
            this.btnBetoltes.Size =
                new System.Drawing.Size(100, 30);
            this.btnBetoltes.Text = "Betöltés";
            this.btnBetoltes.Click +=
                new System.EventHandler(this.btnBetoltes_Click);

            // Keresés
            this.label7.Location = new System.Drawing.Point(20, 160);
            this.label7.AutoSize = true;
            this.label7.Text = "Keresés:";

            this.tbKereses.Location =
                new System.Drawing.Point(90, 155);
            this.tbKereses.Size =
                new System.Drawing.Size(200, 25);
            this.tbKereses.TextChanged +=
                new System.EventHandler(this.tbKereses_TextChanged);

            this.label8.Location = new System.Drawing.Point(310, 160);
            this.label8.AutoSize = true;
            this.label8.Text = "Üzemanyag szűrés:";

            this.cbSzures.Location =
                new System.Drawing.Point(450, 155);
            this.cbSzures.Size =
                new System.Drawing.Size(150, 25);
            this.cbSzures.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSzures.Items.AddRange(new object[]
            {
                "Összes", "Benzin", "Dízel",
                "Hibrid", "Elektromos", "LPG", "Egyéb"
            });
            this.cbSzures.SelectedIndex = 0;
            this.cbSzures.SelectedIndexChanged +=
                new System.EventHandler(this.cbSzures_SelectedIndexChanged);

            // Autók táblázata
            this.dgvAutok.Location =
                new System.Drawing.Point(20, 195);
            this.dgvAutok.Size =
                new System.Drawing.Size(1180, 190);
            this.dgvAutok.AllowUserToAddRows = false;
            this.dgvAutok.ReadOnly = true;
            this.dgvAutok.MultiSelect = false;
            this.dgvAutok.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutok.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvAutok.Columns.Add("Id", "Id");
            this.dgvAutok.Columns.Add("Rendszam", "Rendszám");
            this.dgvAutok.Columns.Add("Marka", "Márka");
            this.dgvAutok.Columns.Add("Modell", "Modell");
            this.dgvAutok.Columns.Add("Evjarat", "Évjárat");
            this.dgvAutok.Columns.Add("Uzemanyag", "Üzemanyag");
            this.dgvAutok.Columns.Add("Km", "Kilométer");
            this.dgvAutok.Columns.Add("Osszes", "Összes költség");
            this.dgvAutok.Columns[0].Visible = false;

            this.dgvAutok.SelectionChanged +=
                new System.EventHandler(this.dgvAutok_SelectionChanged);

            // Összesítés
            this.lblOsszes.Location =
                new System.Drawing.Point(20, 395);
            this.lblOsszes.Size =
                new System.Drawing.Size(1100, 30);
            this.lblOsszes.Font = new System.Drawing.Font(
                "Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblOsszes.Text = "Válassz ki egy autót!";

            // Költségek címe
            this.lblKoltsegCim.AutoSize = true;
            this.lblKoltsegCim.Font = new System.Drawing.Font(
                "Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblKoltsegCim.Location =
                new System.Drawing.Point(20, 440);
            this.lblKoltsegCim.Text = "FENNTARTÁSI KÖLTSÉGEK";

            // Költség adatai
            this.label9.Location = new System.Drawing.Point(20, 495);
            this.label9.AutoSize = true;
            this.label9.Text = "Dátum:";

            this.dtDatum.Location =
                new System.Drawing.Point(80, 490);
            this.dtDatum.Size =
                new System.Drawing.Size(140, 25);
            this.dtDatum.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.label10.Location = new System.Drawing.Point(240, 495);
            this.label10.AutoSize = true;
            this.label10.Text = "Kategória:";

            this.cbKategoria.Location =
                new System.Drawing.Point(330, 490);
            this.cbKategoria.Size =
                new System.Drawing.Size(150, 25);
            this.cbKategoria.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoria.Items.AddRange(new object[]
            {
                "Üzemanyag", "Szerviz", "Gumiabroncs",
                "Biztosítás", "Adó", "Műszaki vizsga",
                "Javítás", "Egyéb"
            });
            this.cbKategoria.SelectedIndex = 0;

            this.label11.Location = new System.Drawing.Point(500, 495);
            this.label11.AutoSize = true;
            this.label11.Text = "Megnevezés:";

            this.tbMegnevezes.Location =
                new System.Drawing.Point(610, 490);
            this.tbMegnevezes.Size =
                new System.Drawing.Size(200, 25);

            this.label12.Location = new System.Drawing.Point(20, 535);
            this.label12.AutoSize = true;
            this.label12.Text = "Összeg:";

            this.tbOsszeg.Location =
                new System.Drawing.Point(80, 530);
            this.tbOsszeg.Size =
                new System.Drawing.Size(140, 25);

            this.label13.Location = new System.Drawing.Point(240, 535);
            this.label13.AutoSize = true;
            this.label13.Text = "Kilométer:";

            this.tbKoltsegKm.Location =
                new System.Drawing.Point(330, 530);
            this.tbKoltsegKm.Size =
                new System.Drawing.Size(150, 25);

            // Költség gombok
            this.btnKoltsegFelvetel.Location =
                new System.Drawing.Point(500, 530);
            this.btnKoltsegFelvetel.Size =
                new System.Drawing.Size(150, 30);
            this.btnKoltsegFelvetel.Text = "Költség felvétele";
            this.btnKoltsegFelvetel.Click +=
                new System.EventHandler(this.btnKoltsegFelvetel_Click);

            this.btnKoltsegModositas.Location =
                new System.Drawing.Point(660, 530);
            this.btnKoltsegModositas.Size =
                new System.Drawing.Size(120, 30);
            this.btnKoltsegModositas.Text = "Módosítás";
            this.btnKoltsegModositas.Click +=
                new System.EventHandler(this.btnKoltsegModositas_Click);

            this.btnKoltsegTorles.Location =
                new System.Drawing.Point(790, 530);
            this.btnKoltsegTorles.Size =
                new System.Drawing.Size(100, 30);
            this.btnKoltsegTorles.Text = "Törlés";
            this.btnKoltsegTorles.Click +=
                new System.EventHandler(this.btnKoltsegTorles_Click);

            // Költségek táblázata
            this.dgvKoltsegek.Location =
                new System.Drawing.Point(20, 580);
            this.dgvKoltsegek.Size =
                new System.Drawing.Size(1180, 190);
            this.dgvKoltsegek.AllowUserToAddRows = false;
            this.dgvKoltsegek.ReadOnly = true;
            this.dgvKoltsegek.MultiSelect = false;
            this.dgvKoltsegek.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKoltsegek.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvKoltsegek.Columns.Add("Id", "Id");
            this.dgvKoltsegek.Columns.Add("Datum", "Dátum");
            this.dgvKoltsegek.Columns.Add("Kategoria", "Kategória");
            this.dgvKoltsegek.Columns.Add("Megnevezes", "Megnevezés");
            this.dgvKoltsegek.Columns.Add("Osszeg", "Összeg");
            this.dgvKoltsegek.Columns.Add("Km", "Kilométer");
            this.dgvKoltsegek.Columns[0].Visible = false;

            this.dgvKoltsegek.SelectionChanged +=
                new System.EventHandler(this.dgvKoltsegek_SelectionChanged);

            // Form1
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize =
                new System.Drawing.Size(1230, 800);
            this.AutoScroll = true;
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autók fenntartási költségei";
            this.Name = "Form1";

            // Vezérlők hozzáadása
            this.Controls.Add(this.lblCim);
            this.Controls.Add(this.lblKoltsegCim);
            this.Controls.Add(this.lblOsszes);

            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);

            this.Controls.Add(this.tbRendszam);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.tbModell);
            this.Controls.Add(this.tbEvjarat);
            this.Controls.Add(this.tbKm);
            this.Controls.Add(this.tbKereses);
            this.Controls.Add(this.tbMegnevezes);
            this.Controls.Add(this.tbOsszeg);
            this.Controls.Add(this.tbKoltsegKm);

            this.Controls.Add(this.cbUzemanyag);
            this.Controls.Add(this.cbSzures);
            this.Controls.Add(this.cbKategoria);

            this.Controls.Add(this.dtDatum);

            this.Controls.Add(this.btnAutoFelvetel);
            this.Controls.Add(this.btnAutoTorles);
            this.Controls.Add(this.btnKoltsegFelvetel);
            this.Controls.Add(this.btnKoltsegModositas);
            this.Controls.Add(this.btnKoltsegTorles);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnBetoltes);

            this.Controls.Add(this.dgvAutok);
            this.Controls.Add(this.dgvKoltsegek);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAutok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoltsegek)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
