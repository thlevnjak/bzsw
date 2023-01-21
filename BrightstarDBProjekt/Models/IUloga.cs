using BrightstarDB.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightstarDBProjekt.Models
{
    [Entity]
    public interface IUloga
    {
        string UlogaID { get; }
        string Vrsta { get; set; }
        string Opis { get; set; }
        [InverseProperty("Uloga")]
        ICollection<IKorisnik> Korisnici { get; }
    }
}
