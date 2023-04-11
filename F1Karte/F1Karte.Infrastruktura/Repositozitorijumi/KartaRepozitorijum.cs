using F1Karte.Domen.Modeli;
using F1Karte.Infrastruktura.Context;
using F1Karte.Infrastruktura.Interfejsi;
using Microsoft.EntityFrameworkCore;

namespace F1Karte.Infrastruktura.Repositozitorijumi
{
    public class KartaRepozitorijum : IKartaRepozitorijum
    {
        public F1KarteDBContext _ctx;

        public KartaRepozitorijum()
        {
            _ctx = new F1KarteDBContext();
        }

        public Karta Azuriraj(Karta obj)
        {
            try
            {
                _ctx.Entry(obj).State = EntityState.Modified;

                return obj;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Karta Dodaj(Karta obj)
        {
            return _ctx.Karte.Add(obj).Entity;
        }

        public async Task<IEnumerable<Karta>> Obrisi(object ID)
        {
            var postoji = await PrikazSvihKarataPoIDAsync(ID);
            if (postoji is null)
                throw new KartaNijePronadjenaException("Pogresan ID karte!");

            var podatci = _ctx.Karte.Remove((Karta)postoji);

            return null;
        }

        public async Task<IEnumerable<Karta>> PrikazSvihKarataAsync()
        {
            var podatci = await _ctx.Karte
                .ToListAsync();

            return podatci;
        }

        public async Task<IEnumerable<Karta>> PrikazSvihKarataPoCeniAsync(object Cena)
        {
            var podatci = await _ctx.Karte
                    .Where(x => x.CenaKarte == (int)Cena).ToListAsync();

            return podatci;
        }

        public async Task<IEnumerable<Karta>> PrikazSvihKarataPoGraduAsync(object Grad)
        {
            var podatci = await _ctx.Karte
                .Where(x => x.Grad == (string)Grad).ToArrayAsync();

            return podatci;
        }

        public async Task<IEnumerable<Karta>> PrikazSvihKarataPoIDAsync(object ID)
        {
                var podatci = await _ctx.Karte
                .Where(x => x.ID_Karte == ID).ToArrayAsync();

            return podatci;
        }



        public void Sacuvaj()
        {
            _ctx.SaveChanges();
        }
    }
}
