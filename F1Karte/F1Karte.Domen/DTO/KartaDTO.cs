using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Karte.Domen.DTO
{
    internal class KartaDTO
    {
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string NazivStaze { get; set; }
        public double CenaKarte { get; set; }
        public int BrDana { get; set; }
        public string Tribina { get; set; }
    }
}
