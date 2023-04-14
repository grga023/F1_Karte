using F1Karte.Aplikacija.Interfejsi;
using F1Karte.Aplikacija.Servisi;
using F1Karte.Domen.Modeli;

namespace F1Karte.UI
{
    public partial class Form1 : Form
    {
        private IKartaServis _kartaServis;
        private string filteri;
        
        public Form1(IKartaServis kartaServis)
        {
            _kartaServis = kartaServis;
            _ = InitPrikaz();
            InitializeComponent();
            OmnemoguciFilter();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Karta kartaZaDodati = new();

                kartaZaDodati.Drzava = txtDrzava.Text;
                kartaZaDodati.Grad = txtGrad.Text;
                kartaZaDodati.BrDana = Int32.Parse(txtBrDana.Text);
                kartaZaDodati.Tribina = txtTribina.Text;
                kartaZaDodati.DateTime = DateTime.Parse(date.Text);
                kartaZaDodati.CenaKarte = Int32.Parse(txtCenaKarte.Text);
                kartaZaDodati.NazivStaze = txtStaza.Text;
            
                await _kartaServis.KreirajNovuKartu(kartaZaDodati);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            _ = InitPrikaz();
        }

        private async Task InitPrikaz()
        {
            try
            {
                var karte = await _kartaServis.PrikazSvihKarataAsync();
                dataGridView1.DataSource = karte;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async Task Filter(string filter, object param)
        {
            if (param != "" && filter != "")
            {
                IEnumerable<Karta> kartaFilter = null;

                try
                {
                    switch (filter)
                    {
                        case "Grad":
                            kartaFilter = await _kartaServis.PrikazSvihKarataPoGraduAsync(param);
                            break;
                        case "Cena":
                            kartaFilter = await _kartaServis.PrikazSvihKarataPoCeniAsync(Convert.ToInt32(param));
                            break;
                        default:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                dataGridView1.DataSource = kartaFilter;
            }
            else
            {
                _ = InitPrikaz();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selektovaniRed = dataGridView1.Rows[e.RowIndex];

                txtDrzava.Text = selektovaniRed.Cells["Drzava"].Value.ToString();
                txtGrad.Text = selektovaniRed.Cells["Grad"].Value.ToString();
                txtBrDana.Text = selektovaniRed.Cells["BrDana"].Value.ToString();
                txtStaza.Text = selektovaniRed.Cells["NazivStaze"].Value.ToString();
                txtTribina.Text = selektovaniRed.Cells["Tribina"].Value.ToString();
                txtCenaKarte.Text = selektovaniRed.Cells["CenaKarte"].Value.ToString();
                txtID.Text = selektovaniRed.Cells["ID_Karte"].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbFilterCena_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilterCena.Checked)
            {
                txtFilterCena.Enabled = true;
                filteri = "Cena";
            }
            else
            {
                txtFilterCena.Enabled = false;
                filteri = "";
            }
        }

        private void cbFilterGrad_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilterGrad.Checked)
            {
                txtFilterGrad.Enabled = true;
                filteri = "Grad";
            }
            else
            {
                txtFilterGrad.Enabled = false;
                filteri = "";
            }
        }

        public void OmnemoguciFilter()
        {
            txtFilterCena.Enabled = false;
            txtFilterGrad.Enabled = false;
        }

        private string UzmiParametar()
        {
            if (txtFilterCena.Enabled)
            {
                return txtFilterCena.Text;
            }
            else if (txtFilterGrad.Enabled)
            {
                return txtFilterGrad.Text;
            }
            else
            {
                return "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var podataZaFilter = UzmiParametar();
            _ = Filter(filteri, podataZaFilter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _kartaServis.ObrisiKartu(txtID.Text);
            _ = InitPrikaz();
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = txtID.Text;

                Karta kartaZaIzmenu = new();

                kartaZaIzmenu.Drzava = txtDrzava.Text;
                kartaZaIzmenu.Grad = txtGrad.Text;
                kartaZaIzmenu.BrDana = Int32.Parse(txtBrDana.Text);
                kartaZaIzmenu.Tribina = txtTribina.Text;
                kartaZaIzmenu.DateTime = DateTime.Parse(date.Text);
                kartaZaIzmenu.CenaKarte = Int32.Parse(txtCenaKarte.Text);
                kartaZaIzmenu.NazivStaze = txtStaza.Text;

                await _kartaServis.AzurirajKartu(kartaZaIzmenu, ID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            _ = InitPrikaz();
        }
    }
}
