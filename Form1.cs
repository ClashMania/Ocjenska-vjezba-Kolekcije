using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;


namespace OcijenskaVijezbaKolekcije
{
    internal class Osoba
    {
        string ime, prezime;
        int god;
        string rod, dodatak;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int God { get => god; set => god = value; }
        public string Rod { get => rod; set => rod = value; }
        public string Dodatak { get => dodatak; set => dodatak = value; }

        public Osoba(string ime, string prezime, int god, string rod)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.god = god;
            this.rod = rod;
        }

        public override string ToString()
        {
            string ispis = this.ime + "\t" + this.prezime + "\t" + this.god + "\t" + this.rod + "\t" + this.dodatak + "\r\n";
            return ispis;
        }
    }
    public partial class Form1 : Form
    {
        List<Osoba> osobaList = new List<Osoba>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnos_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "" || txtPrezime.Text == "" || txtGod.Text == "" || cmbxRod.Text == "")
            {
                MessageBox.Show("Greska. Pokušaj ponovo.", "Krivi unos", MessageBoxButtons.OK);
                txtIme.Clear();
                txtPrezime.Clear();
                txtGod.Clear();
            }
            else
            {
                Osoba osoba = new Osoba(txtIme.Text, txtPrezime.Text, Convert.ToInt16(txtGod.Text), cmbxRod.Text);
                osobaList.Add(osoba);
                txtIme.Clear();
                txtPrezime.Clear();
                txtGod.Clear();
            }
        }

        private void BtnIspis_Click(object sender, EventArgs e)
        {
            TxtBox.Clear();

            TxtBox.AppendText("Ime \tPrezime \tGod \tRod \tDodatak \r\n");

            foreach (Osoba o in osobaList)
            {
                TxtBox.AppendText(o.ToString());
            }
        }

        private void BtnObrada_Click(object sender, EventArgs e)
        {
            foreach (Osoba o in osobaList)
            {
                if (o.Rod == "M")
                {
                    o.Dodatak = "Ima brkove";
                }
                else
                {
                    o.Dodatak = "Neam brkove";
                }
            }
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            StreamWriter writer = null;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                writer = new StreamWriter(saveFileDialog.OpenFile());

                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(osobaList);
                }
                writer.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}