using F1Karte.Domen.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Karte.Aplikacija.Interfejsi
{
    public interface IKartaServis
    {
        Task<IEnumerable<Karta>> PrikazSvihKarataAsync();
        Task<IEnumerable<Karta>> PrikazSvihKarataPoCeniAsync(object Cena);
        Task<IEnumerable<Karta>> PrikazSvihKarataPoGraduAsync(object Grad);
        Task AzurirajKartu(Karta obj, object ID);
        Task KreirajNovuKartu(Karta KartaModel);
        void ObrisiKartu(object ID);
        bool PostojiKartaUBaziPodataka();
    }
}
