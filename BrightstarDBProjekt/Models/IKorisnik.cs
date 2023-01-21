using BrightstarDB.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightstarDBProjekt.Models
{
    [Entity]
    public interface IKorisnik
    {
        string KorisnikID { get; }
        string Ime { get; set; }
        string Prezime { get; set; }
        string KorisnickoIme { get; set; }
        string Lozinka { get; set; }
        IUloga Uloga { get; set; }
    }
}