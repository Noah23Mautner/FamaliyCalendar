using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Calendar.Klase
{
    internal class Obitelj
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public List<Korisnik> Clanovi { get; set; } = new List<Korisnik>();
    }
}
