using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1Karte.Domen.Modeli
{
    public class Karta
    {
        [Key]
        public string ID_Karte { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public DateTime DateTime { get; set; }
        public string NazivStaze { get; set; }
        public double CenaKarte { get; set; }
        public int BrDana { get; set; }
        public string Tribina { get; set; }
    }
}
