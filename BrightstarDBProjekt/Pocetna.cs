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
    public partial class Pocetna : Form
    {
        IKorisnik korisnik;
        MyEntityContext context;
        IKorisnik dohvacenKorisnik;
        public Pocetna(MyEntityContext context, IKorisnik korisnik)
        {
            this.context = context;
            this.korisnik = korisnik;
            InitializeComponent();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource
            {
                DataSource = context.Korisniks.Select(x => x).ToList()
            };
            dgvKorisnici.DataSource = bindingSource;
            dgvKorisnici.Columns["Uloga"].Visible = false;
            lblTrenutni.Text = korisnik.Ime + " " + korisnik.Prezime + "\n" + korisnik.Uloga.Vrsta;
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            Prijava frmPrijava = new Prijava(context);
            frmPrijava.ShowDialog();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            dohvacenKorisnik.Ime = txtIme.Text;
            dohvacenKorisnik.Prezime = txtPrezime.Text;
            dohvacenKorisnik.Lozinka = txtLozinka.Text;
            context.SaveChanges();

            BindingSource bindingSource = new BindingSource
            {
                DataSource = context.Korisniks.Select(x => x).ToList()
            };
            dgvKorisnici.DataSource = bindingSource;
        }

        private void dgvKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIme.Text = dgvKorisnici.Rows[e.RowIndex].Cells["Ime"].Value.ToString();
            txtPrezime.Text = dgvKorisnici.Rows[e.RowIndex].Cells["Prezime"].Value.ToString();
            txtLozinka.Text = dgvKorisnici.Rows[e.RowIndex].Cells["Lozinka"].Value.ToString();

            dohvacenKorisnik = context.Korisniks.Where(x => x.KorisnickoIme.Equals(dgvKorisnici.Rows[e.RowIndex].Cells["KorisnickoIme"].Value.ToString())).FirstOrDefault();
        }
    }
}
