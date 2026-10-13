
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace autok
{
    public partial class Form1 : Form
    {
        string autoFajl = "autok.csv";
        string koltsegFajl = "koltsegek.csv";

        List<Auto> autok = new List<Auto>();
        List<Koltseg> koltsegek = new List<Koltseg>();

        int autoId = -1;
        int koltsegId = -1;
        bool frissites = false;

        public Form1()
        {
            InitializeComponent();
            Betoltes();
            Megjelenites();
        }

        void Betoltes()
        {
            autok.Clear();
            koltsegek.Clear();

            string[] sorok = File.ReadAllLines(autoFajl);

            for (int i = 1; i < sorok.Length; i++)
            {
                if (sorok[i] == "") continue;

                string[] adat = sorok[i].Split(';');
                Auto a = new Auto();

                a.Id = int.Parse(adat[0]);
                a.Rendszam = adat[1];
                a.Marka = adat[2];
                a.Modell = adat[3];
                a.Evjarat = int.Parse(adat[4]);
                a.Uzemanyag = adat[5];
                a.Km = int.Parse(adat[6]);

                autok.Add(a);
            }

            sorok = File.ReadAllLines(koltsegFajl);

            for (int i = 1; i < sorok.Length; i++)
            {
                if (sorok[i] == "") continue;

                string[] adat = sorok[i].Split(';');
                Koltseg k = new Koltseg();

                k.Id = int.Parse(adat[0]);
                k.AutoId = int.Parse(adat[1]);
                k.Datum = DateTime.Parse(adat[2]);
                k.Kategoria = adat[3];
                k.Megnevezes = adat[4];
                k.Osszeg = decimal.Parse(adat[5]);
                k.Km = int.Parse(adat[6]);

                koltsegek.Add(k);
            }
        }

        void Mentes()
        {
            List<string> sorok = new List<string>();
            sorok.Add("Id;Rendszám;Márka;Modell;Évjárat;Üzemanyag;Km");

            foreach (Auto a in autok)
                sorok.Add(a.Id + ";" + a.Rendszam + ";" + a.Marka +";" + a.Modell + ";" + a.Evjarat + ";" + a.Uzemanyag + ";" + a.Km);

            File.WriteAllLines(autoFajl, sorok);

            sorok.Clear();
            sorok.Add("Id;AutoId;Dátum;Kategória;Megnevezés;Összeg;Km");

            foreach (Koltseg k in koltsegek)
                sorok.Add(k.Id + ";" + k.AutoId + ";" +
                    k.Datum.ToString("yyyy.MM.dd.") + ";" +
                    k.Kategoria + ";" + k.Megnevezes + ";" +
                    k.Osszeg.ToString(
                        System.Globalization.CultureInfo.InvariantCulture) +
                    ";" + k.Km);

            File.WriteAllLines(koltsegFajl, sorok);
        }

        void Megjelenites()
        {
            frissites = true;
            dgvAutok.Rows.Clear();

            foreach (Auto a in autok)
            {
                string keres = tbKereses.Text.ToLower();

                if (!(a.Rendszam + a.Marka + a.Modell)
                    .ToLower().Contains(keres)) continue;

                if (cbSzures.Text != "Összes" &&
                    cbSzures.Text != a.Uzemanyag) continue;

                decimal osszes = 0;

                foreach (Koltseg k in koltsegek)
                    if (k.AutoId == a.Id) osszes += k.Osszeg;

                dgvAutok.Rows.Add(a.Id, a.Rendszam, a.Marka, a.Modell, a.Evjarat, a.Uzemanyag, a.Km, osszes + " Ft");
            }

            dgvAutok.ClearSelection();
            dgvAutok.CurrentCell = null;
            autoId = -1;
            frissites = false;
            KoltsegekMegjelenitese();
        }

        void KoltsegekMegjelenitese()
        {
            frissites = true;
            dgvKoltsegek.Rows.Clear();

            decimal osszes = 0;

            foreach (Koltseg k in koltsegek)
            {
                if (k.AutoId == autoId)
                {
                    dgvKoltsegek.Rows.Add(k.Id,
                        k.Datum.ToString("yyyy.MM.dd."),
                        k.Kategoria, k.Megnevezes,
                        k.Osszeg + " Ft", k.Km);

                    osszes += k.Osszeg;
                }
            }

            lblOsszes.Text = "Összes költség: " + osszes + " Ft";
            dgvKoltsegek.ClearSelection();
            dgvKoltsegek.CurrentCell = null;
            koltsegId = -1;
            frissites = false;
        }

        private void dgvAutok_SelectionChanged(object sender, EventArgs e)
        {
            if (frissites || dgvAutok.SelectedRows.Count == 0) return;

            autoId = Convert.ToInt32(dgvAutok.SelectedRows[0].Cells[0].Value);

            KoltsegekMegjelenitese();
        }

        private void dgvKoltsegek_SelectionChanged(object sender, EventArgs e)
        {
            if (frissites || dgvKoltsegek.SelectedRows.Count == 0) return;

            koltsegId = Convert.ToInt32(
                dgvKoltsegek.SelectedRows[0].Cells[0].Value);

            foreach (Koltseg k in koltsegek)
            {
                if (k.Id == koltsegId)
                {
                    dtDatum.Value = k.Datum;
                    cbKategoria.Text = k.Kategoria;
                    tbMegnevezes.Text = k.Megnevezes;
                    tbOsszeg.Text = k.Osszeg.ToString();
                    tbKoltsegKm.Text = k.Km.ToString();
                }
            }
        }

        private void btnAutoFelvetel_Click(object sender, EventArgs e)
        {
            int ev, km;

            if (tbRendszam.Text == "" || tbMarka.Text == "" || tbModell.Text == "" ||
                !int.TryParse(tbEvjarat.Text, out ev) || !int.TryParse(tbKm.Text, out km) ||
                ev < 1886 || km < 0)
            {
                MessageBox.Show("Hibás autóadatok!");
                return;
            }

            foreach (Auto a in autok)
            {
                if (a.Rendszam.ToUpper() == tbRendszam.Text.ToUpper())
                {
                    MessageBox.Show("Ez a rendszám már létezik!");
                    return;
                }
            }

            int id = 1;
            foreach (Auto a in autok)
            {
               if (a.Id >= id) id = a.Id + 1;
            }

            Auto uj = new Auto();
            uj.Id = id;
            uj.Rendszam = tbRendszam.Text.ToUpper();
            uj.Marka = tbMarka.Text;
            uj.Modell = tbModell.Text;
            uj.Evjarat = ev;
            uj.Uzemanyag = cbUzemanyag.Text;
            uj.Km = km;

            autok.Add(uj);
            Mentes();
            Megjelenites();
        }

        private void btnAutoTorles_Click(object sender, EventArgs e)
        {
            if (autoId == -1) return;

            if (MessageBox.Show("Biztosan törlöd az autót és a költségeit?",
                "Törlés", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            for (int i = koltsegek.Count - 1; i >= 0; i--)
                if (koltsegek[i].AutoId == autoId)
                    koltsegek.RemoveAt(i);

            for (int i = autok.Count - 1; i >= 0; i--)
                if (autok[i].Id == autoId)
                    autok.RemoveAt(i);

            Mentes();
            Megjelenites();
        }

        private void btnKoltsegFelvetel_Click(object sender, EventArgs e)
        {
            decimal osszeg;
            int km;

            if (autoId == -1 || tbMegnevezes.Text == "" ||
                !decimal.TryParse(tbOsszeg.Text, out osszeg) ||
                !int.TryParse(tbKoltsegKm.Text, out km) ||
                osszeg <= 0 || km < 0)
            {
                MessageBox.Show("Válassz autót és adj meg helyes adatokat!");
                return;
            }

            int id = 1;
            foreach (Koltseg k in koltsegek)
                if (k.Id >= id) id = k.Id + 1;

            Koltseg uj = new Koltseg();
            uj.Id = id;
            uj.AutoId = autoId;
            uj.Datum = dtDatum.Value;
            uj.Kategoria = cbKategoria.Text;
            uj.Megnevezes = tbMegnevezes.Text;
            uj.Osszeg = osszeg;
            uj.Km = km;

            koltsegek.Add(uj);

            foreach (Auto a in autok)
                if (a.Id == autoId && km > a.Km)
                    a.Km = km;

            Mentes();
            Megjelenites();
        }

        private void btnKoltsegModositas_Click(object sender, EventArgs e)
        {
            decimal osszeg;
            int km;

            if (koltsegId == -1 || tbMegnevezes.Text == "" ||
                !decimal.TryParse(tbOsszeg.Text, out osszeg) ||
                !int.TryParse(tbKoltsegKm.Text, out km) ||
                osszeg <= 0 || km < 0)
            {
                MessageBox.Show("Hibás adatok vagy nincs kijelölt költség!");
                return;
            }

            foreach (Koltseg k in koltsegek)
            {
                if (k.Id == koltsegId)
                {
                    k.Datum = dtDatum.Value;
                    k.Kategoria = cbKategoria.Text;
                    k.Megnevezes = tbMegnevezes.Text;
                    k.Osszeg = osszeg;
                    k.Km = km;

                    foreach (Auto a in autok)
                        if (a.Id == k.AutoId && km > a.Km)
                            a.Km = km;

                    break;
                }
            }

            Mentes();
            Megjelenites();
        }

        private void btnKoltsegTorles_Click(object sender, EventArgs e)
        {
            if (koltsegId == -1) return;

            for (int i = koltsegek.Count - 1; i >= 0; i--)
                if (koltsegek[i].Id == koltsegId)
                    koltsegek.RemoveAt(i);

            Mentes();
            Megjelenites();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            Mentes();
            MessageBox.Show("Sikeres mentés!");
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            Betoltes();
            Megjelenites();
        }

        private void tbKereses_TextChanged(object sender, EventArgs e)
        {
            Megjelenites();
        }

        private void cbSzures_SelectedIndexChanged(object sender, EventArgs e)
        {
            Megjelenites();
        }
    }

    public class Auto
    {
        public int Id { get; set; }
        public string Rendszam { get; set; }
        public string Marka { get; set; }
        public string Modell { get; set; }
        public int Evjarat { get; set; }
        public string Uzemanyag { get; set; }
        public int Km { get; set; }
    }

    public class Koltseg
    {
        public int Id { get; set; }
        public int AutoId { get; set; }
        public DateTime Datum { get; set; }
        public string Kategoria { get; set; }
        public string Megnevezes { get; set; }
        public decimal Osszeg { get; set; }
        public int Km { get; set; }
    }
}
