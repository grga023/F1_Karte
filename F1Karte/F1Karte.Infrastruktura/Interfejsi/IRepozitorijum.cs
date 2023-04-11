using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Karte.Infrastruktura.Interfejsi
{
    public interface IRepozitorijum<T> where T : class
    {
        void Obrisi(object PK);
        Task<IEnumerable<T>> PrikazSvihKarataAsync();
        Task<IEnumerable<T>> PrikazSvihKarataPoCeniAsync(object Cena);
        Task<IEnumerable<T>> PrikazSvihKarataPoGraduAsync(object Grad);
        T PrikaziPoIDAsync(object ID);
        T Dodaj(T obj);
        T Azuriraj(T obj);
        void Sacuvaj();

    }
}
