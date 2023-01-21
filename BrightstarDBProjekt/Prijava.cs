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
    public partial class Prijava : Form
    {
        MyEntityContext context;
        public Prijava(MyEntityContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorIme.Text;
            string lozinka = txtLozinka.Text;
            if (korisnickoIme == "" || lozinka == "")
            {
                MessageBox.Show("Treba unijeti korisničko ime i lozinku", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var sviKorisnici = context.Korisniks.Select(x => x).ToList();
                
                for (int i = 0; i < sviKorisnici.Count; i++)
                {
                    if (sviKorisnici[i].KorisnickoIme == korisnickoIme && sviKorisnici[i].Lozinka == lozinka)
                    {
                        Pocetna frmProblemi = new Pocetna(context, sviKorisnici[i]);
                        frmProblemi.ShowDialog();
                        this.Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lblRegistracija_Click(object sender, EventArgs e)
        {
            Hide();
            Registracija frmRegistracija = new Registracija(context);
            frmRegistracija.ShowDialog();
            Close();
        }
    }
}
