using Client.Forms;
using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
    public class UslugaController
    {
        private static UslugaController instance;
        public static UslugaController Instance
        {
            get
            {
                if (instance == null) instance = new UslugaController();
                return instance;
            }
        }
        private UslugaController() { }

        Usluga usluga;
        UCUsluga ucUsluga;
        UCPretrazivanje ucPretrazivanjeUsluga;
        BindingList<Usluga> usluge;
        public delegate void ObradaDogadjaja(Control control);
        public static event ObradaDogadjaja ChangeUC;
        internal async void KreiranjeNoveUsluge()
        {
            ucUsluga = new UCUsluga(UCMode.DodajNovi);
            if (ChangeUC != null)
            {
                ChangeUC(ucUsluga);
                await PopuniComboBox();
                ucUsluga.TxtNaziv.TextChanged += TxtNaziv_TextChanged;
                ucUsluga.TxtCena.TextChanged += TxtCena_TextChanged;
                ucUsluga.TxtTrajanje.TextChanged += TxtTrajanje_TextChanged;
                ucUsluga.CbTipUsluge.SelectedIndexChanged += CbTipUsluge_SelectedIndexChanged;
                ucUsluga.BtnSacuvaj.Click += BtnSacuvaj_Click;
            }
        }
        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    if (ucUsluga.mode == UCMode.DodajNovi)
                    {
                        //ovo je nova usluga koju dodajemo
                        usluga = new Usluga();
                        usluga.Naziv = ucUsluga.TxtNaziv.Text;
                        usluga.Cena = double.Parse(ucUsluga.TxtCena.Text);
                        usluga.TrajanjeUMinutima = int.Parse(ucUsluga.TxtTrajanje.Text);
                        usluga.TipUsluge = (TipUsluge)ucUsluga.CbTipUsluge.SelectedItem;

                        Usluga novaUsluga = await Communication.Instance.KreirajNovuUsluguAsync(usluga);
                        if (novaUsluga != null)
                        {
                            MessageBoxManager.Cancel = "Prikaži";
                            MessageBoxManager.Register();
                            DialogResult res = MessageBox.Show("Sistem je kreirao novu uslugu.", "Uspešno", MessageBoxButtons.OKCancel);
                            if (res == DialogResult.Cancel)
                            {
                                PrikaziUslugu(novaUsluga);
                                ucUsluga.BtnNazad.Visible = false;
                                ucUsluga.BtnIzmeni.Visible = false;
                                ucUsluga.BtnObrisi.Visible = false;
                                ucUsluga.BtnSacuvaj.Visible = false;
                            }
                            else
                            {
                                ucUsluga.TxtNaziv.Text = "";
                                ucUsluga.TxtCena.Text = "";
                                ucUsluga.TxtTrajanje.Text = "";
                                ucUsluga.CbTipUsluge.SelectedIndex = -1;
                            }
                            MessageBoxManager.Unregister();
                        }
                        else
                        {
                            UslugaVecPostoji("kreira novu");
                        }

                    }
                    else
                    {
                        //ovo je usluga vracena iz baze, znaci znamo njen UslugaID a mozemo da menjamo sve ostalo
                        usluga.Naziv = ucUsluga.TxtNaziv.Text;
                        usluga.Cena = double.Parse(ucUsluga.TxtCena.Text);
                        usluga.TrajanjeUMinutima = int.Parse(ucUsluga.TxtTrajanje.Text);
                        usluga.TipUsluge = (TipUsluge)ucUsluga.CbTipUsluge.SelectedItem;

                        if (Communication.Instance.IzmeniUsluguAsync(usluga) != null)
                        {
                            MessageBox.Show("Sistem je izmenio uslugu.", "Uspešno");

                            ucUsluga.TxtNaziv.Enabled = false;
                            ucUsluga.TxtCena.Enabled = false;
                            ucUsluga.TxtTrajanje.Enabled = false;
                            ucUsluga.CbTipUsluge.Enabled = false;
                        }
                        else
                        {
                            UslugaVecPostoji("izmeni");
                        }
                    }
                }
            }
            catch (IOException)
            {
                MainController.Instance.GreskaPriKomunikacijiSaServerom();
            }
            catch (SocketException)
            {
                MainController.Instance.GreskaServerNijePokrenut();
            }

        }

        private async void UslugaVecPostoji(string operacija)
        {
            try
            {
                MessageBoxManager.Yes = "Unesi novu";
                MessageBoxManager.No = "Izmeni ovu";
                MessageBoxManager.Cancel = "Nazad";
                MessageBoxManager.Register();
                DialogResult res = MessageBox.Show($"Sistem ne može da {operacija} uslugu.\nUsluga sa unetim nazivom već postoji u bazi!", "Greška", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                if (res == DialogResult.Yes)
                {
                    ucUsluga.TxtNaziv.Text = "";
                    ucUsluga.TxtCena.Text = "";
                    ucUsluga.TxtTrajanje.Text = "";
                    ucUsluga.CbTipUsluge.SelectedIndex = -1;
                }
                else if (res == DialogResult.No)
                {
                    usluga = await Communication.Instance.UcitajUsluguAsync(usluga);
                    PrikaziUslugu(usluga);
                    ucUsluga.BtnNazad.Visible = false;
                    ucUsluga.BtnIzmeni.PerformClick();
                }
                MessageBoxManager.Unregister();
            }
            catch (IOException)
            {
                MainController.Instance.GreskaPriKomunikacijiSaServerom();
            }
            catch (SocketException)
            {
                MainController.Instance.GreskaServerNijePokrenut();
            }
        }

        private bool IsValid()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(ucUsluga.TxtNaziv.Text))
            {
                ucUsluga.LblErrorNaziv.Text = "Morate uneti naziv usluge.";
                ucUsluga.LblErrorNaziv.Visible = true;
                valid = false;
            }
            if (ucUsluga.CbTipUsluge.SelectedIndex == -1)
            {
                ucUsluga.LblErrorTipUsluge.Text = "Morate izabrati tip usluge.";
                ucUsluga.LblErrorTipUsluge.Visible = true;
                valid = false;
            }
            if (string.IsNullOrEmpty(ucUsluga.TxtCena.Text) || double.TryParse(ucUsluga.TxtCena.Text, out double cena) == false || cena < 1)
            {
                ucUsluga.LblErrorCena.Text = "Morate uneti brojčanu vrednost za cenu usluge.";
                ucUsluga.LblErrorCena.Visible = true;
                valid = false;
            }
            if (string.IsNullOrEmpty(ucUsluga.TxtTrajanje.Text) || int.TryParse(ucUsluga.TxtTrajanje.Text, out int trajanje) == false || trajanje < 1)
            {
                ucUsluga.LblErrorTrajanje.Text = "Morate uneti brojčanu vrednost za trajanje usluge.";
                ucUsluga.LblErrorTrajanje.Visible = true;
                valid = false;
            }

            return valid;
        }

        #region Text Changed dogadjaji
        private void CbTipUsluge_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucUsluga.LblErrorTipUsluge.Visible = false;
        }

        private void TxtTrajanje_TextChanged(object sender, EventArgs e)
        {
            ucUsluga.LblErrorTrajanje.Visible = false;
        }

        private void TxtCena_TextChanged(object sender, EventArgs e)
        {
            ucUsluga.LblErrorCena.Visible = false;
        }

        private void TxtNaziv_TextChanged(object sender, EventArgs e)
        {
            ucUsluga.LblErrorNaziv.Visible = false;
        }
        #endregion

        private async Task PopuniComboBox()
        {
            try
            {
                List<TipUsluge> tipoviUsluga = await Communication.Instance.VratiTipoveUslugaAsync();
                ucUsluga.CbTipUsluge.DataSource = tipoviUsluga;
                ucUsluga.CbTipUsluge.SelectedIndex = -1;
            }
            catch (IOException)
            {
                MainController.Instance.GreskaPriKomunikacijiSaServerom();
            }
            catch (SocketException)
            {
                MainController.Instance.GreskaServerNijePokrenut();
            }
        }

        internal void PretrazivanjeUsluga()
        {
            ucPretrazivanjeUsluga = new UCPretrazivanje();
            ucPretrazivanjeUsluga.GroupBox1.Text = "Pretraživanje usluga";
            ucPretrazivanjeUsluga.BtnIzaberi.Text = "Izaberi uslugu";
            if (ChangeUC != null)
            {
                ChangeUC(ucPretrazivanjeUsluga);
                UcitajDGV();
                ucPretrazivanjeUsluga.TxtPretraga.TextChanged += TxtPretraga_TextChanged;
                ucPretrazivanjeUsluga.BtnIzaberi.Click += BtnIzaberi_Click;
            }

        }

        private async void BtnIzaberi_Click(object sender, EventArgs e)
        {
            if (ucPretrazivanjeUsluga.DgvPodaci.SelectedCells.Count == 0)
            {
                MessageBox.Show("Morate odabrati uslugu iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowIndex = ucPretrazivanjeUsluga.DgvPodaci.SelectedCells[0].RowIndex;
            usluga = (Usluga)ucPretrazivanjeUsluga.DgvPodaci.Rows[rowIndex].DataBoundItem;

            try
            {
                usluga = await Communication.Instance.UcitajUsluguAsync(usluga);
                if (usluga == null)
                {
                    MessageBox.Show("Sistem ne može da učita uslugu.", "Greška");
                    return;
                }
                PrikaziUslugu(usluga);
            }
            catch (IOException)
            {
                MainController.Instance.GreskaPriKomunikacijiSaServerom();
            }
            catch (SocketException)
            {
                MainController.Instance.GreskaServerNijePokrenut();
            }
        }

        internal async void PrikaziUslugu(Usluga usluga)
        {
            if (ChangeUC != null)
            {
                ucUsluga = new UCUsluga(UCMode.Prikazi);
                await PopuniPoljaUsluge(usluga);
                ChangeUC(ucUsluga);
                if (MainController.Instance.korisnik.Vlasnik == false)
                {
                    ucUsluga.BtnIzmeni.Visible = false;
                    ucUsluga.BtnObrisi.Visible = false;
                    ucUsluga.BtnSacuvaj.Visible = false;
                    ucUsluga.BtnZakazi.Visible = true;
                    ucUsluga.BtnZakazi.Click += BtnZakazi_Click;
                }
                else
                {
                    ucUsluga.BtnIzmeni.Click += BtnIzmeni_Click;
                    ucUsluga.BtnObrisi.Click += BtnObrisi_Click;
                    ucUsluga.BtnSacuvaj.Click += BtnSacuvaj_Click;
                }
                ucUsluga.BtnNazad.Click += BtnNazad_Click;
            }
        }

        private void BtnZakazi_Click(object sender, EventArgs e)
        {
            ZahtevController.Instance.ZakaziTermin(usluga);
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            if (ChangeUC != null)
            {
                ChangeUC(ucPretrazivanjeUsluga);
                UcitajDGV();
            }
        }

        private async void BtnObrisi_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite trajno da obrišete ovu uslugu?", "Brisanje usluge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (await Communication.Instance.ObrisiUsluguAsync(usluga))
                    {
                        MessageBox.Show("Sistem je obrisao uslugu.", "Uspešno");
                        ucUsluga.BtnNazad.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne može da obriše uslugu.", "Greška");
                    }
                }
                catch (IOException)
                {
                    MainController.Instance.GreskaPriKomunikacijiSaServerom();
                }
                catch (SocketException)
                {
                    MainController.Instance.GreskaServerNijePokrenut();
                }

            }
            MessageBoxManager.Unregister();
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            ucUsluga.TxtNaziv.Enabled = true;
            ucUsluga.TxtCena.Enabled = true;
            ucUsluga.TxtTrajanje.Enabled = true;
            ucUsluga.CbTipUsluge.Enabled = true;
        }

        private async Task PopuniPoljaUsluge(Usluga usluga)
        {
            ucUsluga.TxtNaziv.Text = usluga.Naziv;
            ucUsluga.TxtCena.Text = usluga.Cena.ToString();
            ucUsluga.TxtTrajanje.Text = usluga.TrajanjeUMinutima.ToString();
            //popunimo combo box prvo!!!
            await PopuniComboBox();
            ucUsluga.CbTipUsluge.SelectedItem = usluga.TipUsluge;
        }

        private async void TxtPretraga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ucPretrazivanjeUsluga.DgvPodaci.DataSource = null;
                usluge = new BindingList<Usluga>(await Communication.Instance.VratiUslugeAsync(ucPretrazivanjeUsluga.TxtPretraga.Text));
                ucPretrazivanjeUsluga.DgvPodaci.DataSource = usluge;
            }
            catch (IOException)
            {
                MainController.Instance.GreskaPriKomunikacijiSaServerom();
            }
            catch (SocketException)
            {
                MainController.Instance.GreskaServerNijePokrenut();
            }
        }

        private async void UcitajDGV()
        {
            try
            {
                usluge = new BindingList<Usluga>(await Communication.Instance.VratiUslugeAsync(ucPretrazivanjeUsluga.TxtPretraga.Text));
                ucPretrazivanjeUsluga.DgvPodaci.DataSource = usluge;
                ucPretrazivanjeUsluga.DgvPodaci.AutoGenerateColumns = false;
                ucPretrazivanjeUsluga.DgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ucPretrazivanjeUsluga.DgvPodaci.Columns["TipUsluge"].DisplayIndex = 0;
                ucPretrazivanjeUsluga.DgvPodaci.Columns["UslugaID"].Visible = false;
                ucPretrazivanjeUsluga.DgvPodaci.Columns["Values"].Visible = false;
                ucPretrazivanjeUsluga.DgvPodaci.Columns["PrimaryKey"].Visible = false;
                ucPretrazivanjeUsluga.DgvPodaci.Columns["TableName"].Visible = false;
                ucPretrazivanjeUsluga.DgvPodaci.Columns["GetById"].Visible = false;
                ucPretrazivanjeUsluga.DgvPodaci.Columns["JoinQuery"].Visible = false;
                ucPretrazivanjeUsluga.DgvPodaci.Columns["UpdateQuery"].Visible = false;
                ucPretrazivanjeUsluga.DgvPodaci.Columns["Aliaces"].Visible = false;
            }
            catch (IOException)
            {
                MainController.Instance.GreskaPriKomunikacijiSaServerom();
            }
            catch (SocketException)
            {
                MainController.Instance.GreskaServerNijePokrenut();
            }
        }


    }
}
