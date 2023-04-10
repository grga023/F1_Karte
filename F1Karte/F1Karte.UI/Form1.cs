using F1Karte.Aplikacija.Interfejsi;
using F1Karte.Domen.Modeli;

namespace F1Karte.UI
{
    public partial class Form1 : Form
    {
        public IKartaServis _kartaServis;
        public Form1(IKartaServis kartaServis)
        {
            InitializeComponent();
            _kartaServis = kartaServis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Karta kartaZaDodati = new();

            kartaZaDodati.Drzava = txtDrzava.Text;
            kartaZaDodati.Grad = txtGrad.Text;
            kartaZaDodati.BrDana = Int32.Parse(txtBrDana.Text);
            kartaZaDodati.Tribina = txtTribina.Text;
            kartaZaDodati.DateTime = DateTime.Parse(date.Text);
            kartaZaDodati.CenaKarte = Int32.Parse(txtxCenaKarte.Text);
            kartaZaDodati.NazivStaze = txtStaza.Text;

            try
            {
                _kartaServis.KreirajNovuKartu(kartaZaDodati);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}