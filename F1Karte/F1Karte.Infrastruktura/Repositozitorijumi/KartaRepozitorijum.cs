using F1Karte.Domen.Modeli;
using F1Karte.Infrastruktura.Context;
using F1Karte.Infrastruktura.Interfejsi;
using Microsoft.EntityFrameworkCore;

namespace F1Karte.Infrastruktura.Repositozitorijumi
{
    public class KartaRepozitorijum : IKartaRepozitorijum
    {
        public F1KarteDBContext _ctx;

        public KartaRepozitorijum(F1KarteDBContext ctx)
        {
            _ctx = ctx;
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

        public void Obrisi(object ID)
        {
            var postoji = _ctx.Karte.Find(ID);
            if (postoji is null)
                throw new KartaNijePronadjenaException("Pogresan ID karte!");

            _ctx.Karte.Remove(postoji);
        }

        public bool PostojiKarta()
        {
            return _ctx.Karte.Any();
        }

        public Karta PrikaziPoIDAsync(object ID)
        {
            var postoji = _ctx.Karte.Find(ID);
            if (postoji is not null)
            {
                _ctx.Entry(postoji).State = EntityState.Detached;
                return postoji;
            }
            else return null;
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

        public void Sacuvaj()
        {
            _ctx.SaveChanges();
        }
    }
}
