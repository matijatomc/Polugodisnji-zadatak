using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomcMatijaPolugodišnjiZadatak
{
    public partial class Form1 : Form
    {
        List<Unos> Unos = new List<Unos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string Ime = txtIme.Text;
            string Prezime = txtPrezime.Text;
            string Spol = cmbSpol.Text;
            int Godiste;
            bool provjera = int.TryParse(txtGodiste.Text, out Godiste);


            if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtPrezime.Text) || provjera == false || string.IsNullOrWhiteSpace(cmbSpol.Text))
            {
                MessageBox.Show("Ne ispravni unos podataka", "Greška", MessageBoxButtons.OK);
                return;
            }

            Unos.Add(new Unos(Ime, Prezime, Godiste, Spol));
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format("{0, -20} {1, -20} {2, -20} {3, -20} {4, -20}", "Ime", "Prezime","Godište","Spol", "Status"));

            foreach (Unos unos in Unos)
            {
                listBox1.Items.Add(unos.ToString());
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach(Unos unos in Unos)
            {
                unos.ImaLiBrkove();
            }
        }
    }
}
