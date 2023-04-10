using System.ComponentModel.DataAnnotations;

namespace F1Karte.Domain.Modeli
{
    public class Karta
    {
        [Key]
        public int          ID_Karte { get; set; }
        public string       Drzava { get; set; }
        public string       Grad { get; set; }
        public DateTime     DateTime { get; set; }
        public string       NazivStaze { get; set; }
        public double       CenaKarte { get; set; }
        public int          BrDana { get; set; }
        public string       Tribina { get; set; }
    }
}
