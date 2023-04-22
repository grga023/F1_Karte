using F1Karte.Aplikacija.Interfejsi;
using F1Karte.Aplikacija.Servisi;

using F1Karte.Domen.Modeli;

namespace F1Karte.UI
{
    public partial class Form1 : Form
    {
        private readonly IKartaServis _kartaServis;
        private string filteri = "";
        
        public Form1(IKartaServis kartaServis)
        {
            _kartaServis = kartaServis;
            _ = InitFill();
            _ = InitPrikaz();
            InitializeComponent();
            OmnemoguciFilter();
        }

        private async Task InitFill()
        {
            bool podatci = _kartaServis.PostojiKartaUBaziPodataka();
            if (!podatci)
            {
                int[] cenaKarte = { 500, 1500, 5000 };
                string[] tribina = { "Pravac", "Sikana", "VIP" };

                var karte = new List<Karta>
                {
                    new Karta { Drzava = "Australia", Grad = "Melbourne", DateTime = new DateTime(2023, 3, 26), NazivStaze = "Albert Park Grand Prix Circuit" , BrDana = 3, CenaKarte = 500, Tribina = "Pravac"},
                    new Karta { Drzava = "Bahrain", Grad = "Sakhir", DateTime = new DateTime(2023, 4, 2), NazivStaze = "Bahrain International Circuit", BrDana = 3 },
                    new Karta { Drzava = "China", Grad = "Shanghai", DateTime = new DateTime(2023, 4, 16), NazivStaze = "Shanghai International Circuit", BrDana = 3 },
                    new Karta { Drzava = "Azerbaijan", Grad = "Baku", DateTime = new DateTime(2023, 4, 30), NazivStaze = "Baku Grad Circuit", BrDana = 3 },
                    new Karta { Drzava = "Spain", Grad = "Barcelona", DateTime = new DateTime(2023, 5, 14), NazivStaze = "Circuit de Barcelona-Catalunya", BrDana = 3 },
                    new Karta { Drzava = "Monaco", Grad = "Monte Carlo", DateTime = new DateTime(2023, 5, 28), NazivStaze = "Circuit de Monaco", BrDana = 3 },
                    new Karta { Drzava = "Canada", Grad = "Montreal", DateTime = new DateTime(2023, 6, 11), NazivStaze = "Circuit Gilles Villeneuve", BrDana = 3 },
                    new Karta { Drzava = "France", Grad = "Le Castellet", DateTime = new DateTime(2023, 6, 25), NazivStaze = "Circuit Paul Ricard", BrDana = 3 },
                    new Karta { Drzava = "Austria", Grad = "Spielberg", DateTime = new DateTime(2023, 7, 9), NazivStaze = "Red Bull Ring", BrDana = 3 },
                    new Karta { Drzava = "Great Britain", Grad = "Silverstone", DateTime = new DateTime(2023, 7, 16), NazivStaze = "Silverstone Circuit", BrDana = 3 },
                    new Karta { Drzava = "Hungary", Grad = "Mogyoród", DateTime = new DateTime(2023, 7, 30), NazivStaze = "Hungaroring", BrDana = 3 },
                    new Karta { Drzava = "Belgium", Grad = "Spa-Francorchamps", DateTime = new DateTime(2023, 8, 27), NazivStaze = "Circuit de Spa-Francorchamps", BrDana = 3 },
                    new Karta { Drzava = "Netherlands", Grad = "Zandvoort", DateTime = new DateTime(2023, 9, 3), NazivStaze = "Circuit Zandvoort", BrDana = 3 },
                    new Karta { Drzava = "Italy", Grad = "Monza", DateTime = new DateTime(2023, 9, 10), NazivStaze = "Autodromo Nazionale di Monza", BrDana = 3 },
                    new Karta { Drzava = "Russia", Grad = "Sochi", DateTime = new DateTime(2023, 9, 24), NazivStaze = "Sochi Autodrom", BrDana = 3 },
                    new Karta { Drzava = "Singapore", Grad = "Singapore", DateTime = new DateTime(2023, 10, 1), NazivStaze = "Marina Bay Street Circuit", BrDana = 3 },
                    new Karta { Drzava = "Japan", Grad = "Suzuka", DateTime = new DateTime(2023, 10, 8), NazivStaze = "Suzuka Circuit", BrDana = 3 },
                    new Karta { Drzava = "USA", Grad = "Austin", DateTime = new DateTime(2023, 10, 22), NazivStaze = "Circuit of the Americas", BrDana = 3 },
                    new Karta { Drzava = "Mexico", Grad = "Mexico City", DateTime = new DateTime(2023, 10, 29), NazivStaze = "Autódromo Hermanos Rodríguez", BrDana = 3 },
                    new Karta { Drzava = "Brazil", Grad = "São Paulo", DateTime = new DateTime(2023, 11, 12), NazivStaze = "Autódromo José Carlos Pace", BrDana = 3 },
                    new Karta { Drzava = "Saudi Arabia", Grad = "Jeddah", DateTime = new DateTime(2023, 11, 26), NazivStaze = "Jeddah Corniche Circuit", BrDana = 3 },
                    new Karta { Drzava = "Abu Dhabi", Grad = "Yas Island", DateTime = new DateTime(2023, 12, 3), NazivStaze = "Yas Marina Circuit", BrDana = 3 }
                };

                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        foreach (var item in karte)
                        {
                            Karta kartaZaDodati = new()
                            {
                                Drzava = item.Drzava,
                                Grad = item.Grad,
                                BrDana = item.BrDana,
                                Tribina = tribina[i],
                                DateTime = item.DateTime,
                                CenaKarte = cenaKarte[i],
                                NazivStaze = item.NazivStaze
                            };

                            await _kartaServis.KreirajNovuKartu(kartaZaDodati);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Karta kartaZaDodati = new()
                {
                    Drzava = txtDrzava.Text,
                    Grad = txtGrad.Text,
                    BrDana = Int32.Parse(txtBrDana.Text),
                    Tribina = txtTribina.Text,
                    DateTime = DateTime.Parse(date.Text),
                    CenaKarte = Int32.Parse(txtCenaKarte.Text),
                    NazivStaze = txtStaza.Text
                };

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
                dataGridView1.Columns["ID_Karte"].HeaderText = "ID";
                dataGridView1.Columns["ID_Karte"].Width = 130;
                dataGridView1.Columns["Drzava"].Width = 80;
                dataGridView1.Columns["Grad"].Width = 120;
                dataGridView1.Columns["DateTime"].HeaderText = "Datum trke";
                dataGridView1.Columns["DateTime"].Width = 100;
                dataGridView1.Columns["NazivStaze"].HeaderText = "Naziv staze";
                dataGridView1.Columns["NazivStaze"].Width = 200;
                dataGridView1.Columns["CenaKarte"].HeaderText = "Cena";
                dataGridView1.Columns["CenaKarte"].Width = 50;
                dataGridView1.Columns["BrDana"].HeaderText = "Broj dana";
                dataGridView1.Columns["BrDana"].Width = 50;    
                dataGridView1.Columns["Tribina"].Width = 50;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async Task Filter(string filter, object param)
        {
            if (filter != "" && param != "")
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
                cbFilterGrad.Checked = false;
                txtFilterCena.Enabled = true;
                filteri = "Cena";
            }
            else
            {
                txtFilterCena.Enabled = false;
                filteri = "";
                _ = InitPrikaz();
            }
        }

        private void cbFilterGrad_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilterGrad.Checked)
            {
                cbFilterCena.Checked = false;
                txtFilterGrad.Enabled = true;
                filteri = "Grad";
            }
            else
            {
                txtFilterGrad.Enabled = false;
                filteri = "";
                _ = InitPrikaz();
            }
        }

        public void OmnemoguciFilter()
        {
            txtFilterCena.Enabled = false;
            txtFilterGrad.Enabled = false;
        }

        private object UzmiParametar()
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
                return null;
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
