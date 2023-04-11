using F1Karte.Aplikacija.Interfejsi;
using F1Karte.Aplikacija.Servisi;
using F1Karte.Domen.Modeli;

namespace F1Karte.UI
{
    public partial class Form1 : Form
    {
        KartaServis _kartaServis;
        public Form1()
        {
            _kartaServis = new KartaServis();
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Karta kartaZaDodati = new();

            kartaZaDodati.Drzava = txtDrzava.Text;
            kartaZaDodati.Grad = txtGrad.Text;
            kartaZaDodati.BrDana = Int32.Parse(txtBrDana.Text);
            kartaZaDodati.Tribina = txtTribina.Text;
            kartaZaDodati.DateTime = DateTime.Parse(date.Text);
            kartaZaDodati.CenaKarte = Int32.Parse(txtxCenaKarte.Text);
            kartaZaDodati.NazivStaze = txtStaza.Text;

            await _kartaServis.KreirajNovuKartu(kartaZaDodati);
        }
        
        //dataGridView1.DataSource = servisGetAllAsync.ToList();
    }
}
