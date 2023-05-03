using F1Karte.Aplikacija.Interfejsi;
using F1Karte.Domen.Modeli;
using F1Karte.Infrastruktura.Interfejsi;
using F1Karte.Infrastruktura.Repositozitorijumi;

namespace F1Karte.Aplikacija.Servisi
{
    public class KartaServis : IKartaServis
    {
        public IKartaRepozitorijum _kartaRepozitorijum;
        public IValidacioniServis _validacioniServis;

        public KartaServis(IKartaRepozitorijum kartaRepozitorijum, IValidacioniServis validacioniServis)
        {
            _kartaRepozitorijum = kartaRepozitorijum;
            _validacioniServis = validacioniServis;
        }

        private string GenerisiRandomIDKarte()
        {
            string IDZaProveru;
            string ID;

            Random generator = new Random();
            int cifra = generator.Next(1, 1000);
            //lending zero
            string Prva = cifra.ToString("000");
            int cifra2 = generator.Next(1, 1000000000);
            int cifra3 = generator.Next(1, 10000);
            string Drugi = cifra2.ToString("000000000") + cifra3.ToString("0000");

            IDZaProveru = Prva + Drugi;
            long Telo = long.Parse(IDZaProveru);

            long KontrolniBroj = 98 - ((Telo * 100) % 97);
            string KontrolniString = KontrolniBroj.ToString("00");

            ID = Prva + "-" + Drugi + "-" + KontrolniString;

            if (!_validacioniServis.IDJeValidan(ID))
            {
                GenerisiRandomIDKarte();
            }

            return ID;
        }
        public Task AzurirajKartu(Karta obj, object ID)
        {
            var podatci =  _kartaRepozitorijum.PrikaziPoIDAsync(ID);
            if (podatci == null) throw new KartaNijePronadjenaException("Pogresan ID karte!");


            Karta KartaZaDodaati = new()
            {
                ID_Karte = podatci.ID_Karte,
                Drzava = obj.Drzava,
                Grad = obj.Grad,
                DateTime = obj.DateTime,
                NazivStaze = obj.NazivStaze,
                CenaKarte = obj.CenaKarte,
                BrDana = obj.BrDana,
                Tribina = obj.Tribina
            };

            _kartaRepozitorijum.Azuriraj(KartaZaDodaati);
            _kartaRepozitorijum.Sacuvaj();
            return Task.CompletedTask;
        }

        public async Task KreirajNovuKartu(Karta KartaModel)
        {
            //Dodaj novi ID karte
            string IDKarte = GenerisiRandomIDKarte();

            //ID postoji
            var postojiKarta = _kartaRepozitorijum.PrikaziPoIDAsync(IDKarte);
            if (postojiKarta is not null)
                await KreirajNovuKartu(KartaModel);

            
            Karta KartaZaDodaati = new()
            {
                ID_Karte = IDKarte,
                Drzava = KartaModel.Drzava,
                Grad = KartaModel.Grad,
                DateTime = KartaModel.DateTime,
                NazivStaze = KartaModel.NazivStaze,
                CenaKarte = KartaModel.CenaKarte,
                BrDana = KartaModel.BrDana,
                Tribina = KartaModel.Tribina
            };

            _kartaRepozitorijum.Dodaj(KartaZaDodaati);
            _kartaRepozitorijum.Sacuvaj();
        }

        public void ObrisiKartu(object ID)
        {
            _kartaRepozitorijum.Obrisi(ID);

            _kartaRepozitorijum.Sacuvaj();
        }

        public async Task<IEnumerable<Karta>> PrikazSvihKarataAsync()
        {
            var podaci = await _kartaRepozitorijum.PrikazSvihKarataAsync();
            if (podaci is null) throw new KartaNijePronadjenaException("Nema unetih karata!");

            List<Karta> result = new();
            Karta Karta;

            foreach (var item in podaci)
            {
                Karta = new Karta
                {
                    ID_Karte = item.ID_Karte,
                    Drzava = item.Drzava,
                    Grad = item.Grad,
                    DateTime = item.DateTime,
                    NazivStaze = item.NazivStaze,
                    CenaKarte = item.CenaKarte,
                    BrDana = item.BrDana,
                    Tribina = item.Tribina
                };

                result.Add(Karta);
            }

            return result.OrderBy(k => k.DateTime).ToList();
        }

        public async Task<IEnumerable<Karta>> PrikazSvihKarataPoCeniAsync(object Cena)
        {
            var podatci = await _kartaRepozitorijum.PrikazSvihKarataPoCeniAsync(Cena);
            if (podatci is null)
                throw new KartaNijePronadjenaException("Neispravna cena!");

            List<Karta> result = new();
            Karta Karta;

            foreach (var item in podatci)
            {
                Karta = new Karta
                {
                    ID_Karte = item.ID_Karte,
                    Drzava = item.Drzava,
                    Grad = item.Grad,
                    DateTime = item.DateTime,
                    NazivStaze = item.NazivStaze,
                    CenaKarte = item.CenaKarte,
                    BrDana = item.BrDana,
                    Tribina = item.Tribina
                };

                result.Add(Karta);
            }

            return result.OrderBy(k => k.DateTime).ToList();
        }

        public async Task<IEnumerable<Karta>> PrikazSvihKarataPoGraduAsync(object Grad)
        {
            var podatci = await _kartaRepozitorijum.PrikazSvihKarataPoGraduAsync(Grad);
            if (podatci is null)
                throw new KartaNijePronadjenaException("Neispravna cena!");

            List<Karta> result = new();
            Karta Karta;

            foreach (var item in podatci)
            {
                Karta = new Karta
                {
                    ID_Karte = item.ID_Karte,
                    Drzava = item.Drzava,
                    Grad = item.Grad,
                    DateTime = item.DateTime,
                    NazivStaze = item.NazivStaze,
                    CenaKarte = item.CenaKarte,
                    BrDana = item.BrDana,
                    Tribina = item.Tribina
                };

                result.Add(Karta);
            }

            return result.OrderBy(k => k.DateTime).ToList();
        }

        public bool PostojiKartaUBaziPodataka()
        {
            return _kartaRepozitorijum.PostojiKarta();
        }
    }
}
