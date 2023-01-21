using BrightstarDBProjekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrightstarDBProjekt
{
    public partial class Registracija : Form
    {
        MyEntityContext context;
        public Registracija(MyEntityContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korisnickoIme = txtKorIme.Text;
            string lozinka = txtLozinka.Text;
            Uloga novaUloga = new Uloga();
            if (ime == "" || prezime == "" || korisnickoIme == "" || lozinka == "")
            {
                MessageBox.Show("Treba unijeti ime, prezime, korisničko ime i lozinku", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var sveUloge = context.Ulogas.Select(x => x).ToList();

                for (int i = 0; i < sveUloge.Count; i++)
                {
                    if (sveUloge[i].Vrsta == "prometnik")
                    {
                        novaUloga = sveUloge[i] as Uloga;
                    }
                }

                var noviKorisnik = new Korisnik()
                {
                    Ime = ime,
                    Prezime = prezime,
                    KorisnickoIme = korisnickoIme,
                    Lozinka = lozinka,
                    Uloga = novaUloga
                };

                if (noviKorisnik != null)
                {
                    context.Korisniks.Add(noviKorisnik);
                    context.SaveChanges();
                    MessageBox.Show("Korisnik uspješno registriran", "Registracija uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Prijava frmPrijava = new Prijava(context);
                    frmPrijava.ShowDialog();
                }
            }
        }

        private void lblPrijava_Click(object sender, EventArgs e)
        {
            Hide();
            Prijava frmPrijava = new Prijava(context);
            frmPrijava.ShowDialog();
            Close();
        }
    }
}
