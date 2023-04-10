<<<<<<< Updated upstream
﻿using F1Karte.Domain.Modeli;
=======
﻿using F1Karte.Domen.Modeli;
>>>>>>> Stashed changes
using F1Karte.Infrastruktura.Context;
using F1Karte.Infrastruktura.Interfejsi;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<Karta> Obrisi(object ID)
        {
            Karta postoji = await PrikazSvihKarataPoIDAsync(ID);
            if (postoji is null)
                throw new KartaNijePronadjenaException("Pogresan ID karte!");

            var podatci = _ctx.Karte.Remove(postoji);

            return podatci.Entity;
        }

        public async Task<IEnumerable<Karta>> PrikazSvihKarataAsync()
        {
            var podatci = await _ctx.Karte
                .ToListAsync();

            return podatci;
        }

        public async Task<Karta> PrikazSvihKarataPoCeniAsync(object Cena)
        {
            var podatci = await _ctx.Karte
                .FirstOrDefaultAsync(x => x.CenaKarte == (int)Cena);

            return podatci;
        }

        public async Task<Karta> PrikazSvihKarataPoGraduAsync(object Grad)
        {
            var podatci = await _ctx.Karte
                .FirstOrDefaultAsync(x => x.Grad == (string)Grad);

            return podatci;
        }

        public async Task<Karta> PrikazSvihKarataPoIDAsync(object ID)
        {
            var podatci = await _ctx.Karte
<<<<<<< Updated upstream
                .FirstOrDefaultAsync(x => x.ID_Karte == (int)ID);
=======
                .FirstOrDefaultAsync(x => x.ID_Karte == (string)ID);
>>>>>>> Stashed changes

            return podatci;
        }



        public void Sacuvaj()
        {
            _ctx.SaveChanges();
        }
    }
}
