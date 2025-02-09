using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Calendar.Klase
{
    internal class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Email { get; set; }
        public string LozinkaHash { get; set; }
        public int ObiteljId { get; set; } 
    }
}
