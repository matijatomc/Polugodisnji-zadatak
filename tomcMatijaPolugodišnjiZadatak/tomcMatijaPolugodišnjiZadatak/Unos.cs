using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPolugodišnjiZadatak
{

    class Unos
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godiste { get; set; }
        public string Spol { get; set; }
        public string Status { get; set; }

        public Unos(string ime, string prezime, int godiste, string spol)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Godiste = godiste;
            this.Spol = spol;
        }

        // Sve osobe koje imaju ime "Ana" dobijaju dodatni status nakon obrade "Banana", sve muške osobe dobijaju status "gaser", a sve osobe mlađe od 18 godina "mulac".
        public void ImaLiBrkove()
        {
            if (this.Spol == "M")
            {
                this.Status = "Ima brkove";
            }
            else
            {
                this.Status = "Nema brkove";
            }
        }

        public override string ToString()
        {
            string ispis = string.Format("{0, -20} {1, -20} {2, -20} {3, -20} {4, -20}", this.Ime, this.Prezime, this.Godiste, this.Spol, this.Status);
            return ispis;
        }
    }
}
