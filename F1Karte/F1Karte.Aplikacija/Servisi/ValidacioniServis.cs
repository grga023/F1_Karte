using F1Karte.Aplikacija.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Karte.Aplikacija.Servisi
{
    public class ValidacioniServis : IValidacioniServis
    {
        public bool IDJeValidan(string IDKarte)
        {
            IDKarte = IDKarte.Replace("-", "");

            if (IDKarte.Length < 18)
            {
                return false;
            }
            int controlniBroj = Convert.ToInt32(IDKarte.Substring(IDKarte.Length - 2));
            string KartaSubstring = IDKarte.Substring(0, 16);
            long telo = long.Parse(KartaSubstring);
            if (98 - ((telo * 100) % 97) == controlniBroj)
            {
                return true;
            }
            return false;
        }
    }
}
