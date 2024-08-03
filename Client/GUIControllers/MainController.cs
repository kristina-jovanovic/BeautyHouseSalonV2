using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
    public class MainController
    {
        private static MainController instance;
        public static MainController Instance
        {
            get
            {
                if (instance == null) instance = new MainController();
                return instance;
            }
        }
        private MainController() { }

        public bool logedOut = false;
        FrmMain frmMain;
        public Korisnik korisnik;
        public void ShowFrmMain(Korisnik korisnik)
        {
            this.korisnik = korisnik;
            frmMain = new FrmMain(korisnik);
            if (korisnik.Vlasnik == true)
            {
                UCMeniVlasnik ucMeniVlasnik = new UCMeniVlasnik();
                frmMain.SetMenu(ucMeniVlasnik);
                //frmMain.ChangePanel(ucMeniVlasnik);
                ucMeniVlasnik.BtnOdjaviSe.Click += BtnOdjaviSe_Click;
                ucMeniVlasnik.KreiranjeNoveUslugeToolStripMenuItem.Click += KreiranjeNoveUslugeToolStripMenuItem_Click;
                ucMeniVlasnik.PretrazivanjeUslugaToolStripMenuItem.Click += PretrazivanjeUslugaToolStripMenuItem_Click;
                ucMeniVlasnik.IzmenaUslugeToolStripMenuItem.Click += PretrazivanjeUslugaToolStripMenuItem_Click;
                ucMeniVlasnik.BrisanjeUslugeToolStripMenuItem.Click += PretrazivanjeUslugaToolStripMenuItem_Click;

                ucMeniVlasnik.KreirajProfilRadnikaToolStripMenuItem.Click += KreirajProfilRadnikaToolStripMenuItem_Click;
                ucMeniVlasnik.PretraziProfileRadnikaToolStripMenuItem.Click += PretraziProfileRadnikaToolStripMenuItem_Click;

                ucMeniVlasnik.ZakaziTerminToolStripMenuItem.Click += PretrazivanjeZahtevaToolStripMenuItem_Click;

                ucMeniVlasnik.PretrazivanjeUslugaToolStripMenuItem1.Click += PretrazivanjeUslugaToolStripMenuItem_Click;
                ucMeniVlasnik.PretrazivanjeProfilaRadnikaToolStripMenuItem1.Click += PretraziProfileRadnikaToolStripMenuItem_Click;
            }
            else
            {
                UCMeniKorisnik ucMeniKorisnik = new UCMeniKorisnik();
                frmMain.SetMenu(ucMeniKorisnik);

                ucMeniKorisnik.BtnOdjaviSe.Click += BtnOdjaviSe_Click;
                ucMeniKorisnik.PretraziUslugeToolStripMenuItem.Click += PretrazivanjeUslugaToolStripMenuItem_Click;
                ucMeniKorisnik.PretraziProfileRadnikaToolStripMenuItem.Click += PretraziProfileRadnikaToolStripMenuItem_Click;
                ucMeniKorisnik.ZakaziTerminToolStripMenuItem.Click += ZakaziTerminToolStripMenuItem_Click;
            }
            frmMain.ShowDialog();
        }

        public void GreskaPriKomunikacijiSaServerom()
        {
            MessageBox.Show("Konekcija sa serverom je prekinuta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void PretrazivanjeZahtevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZahtevController.ChangeUC += ChangeUC;
            await ZahtevController.Instance.PretraziZahteve();
        }

        private async void ZakaziTerminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZahtevController.ChangeUC += ChangeUC;
            await ZahtevController.Instance.ZakaziTermin();
        }

        private async void PretraziProfileRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilRadnikaController.ChangeUC += ChangeUC;
            ZahtevController.ChangeUC += ChangeUC;
            await ProfilRadnikaController.Instance.PretraziProfileRadnika();
        }

        private async void KreirajProfilRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilRadnikaController.ChangeUC += ChangeUC;
            await ProfilRadnikaController.Instance.KreirajProfilRadnika();
        }

        private async void PretrazivanjeUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UslugaController.ChangeUC += ChangeUC;
            ZahtevController.ChangeUC += ChangeUC;
            await UslugaController.Instance.PretrazivanjeUsluga();
        }

        private async void KreiranjeNoveUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UslugaController.ChangeUC += ChangeUC;
            await UslugaController.Instance.KreiranjeNoveUsluge();
        }

        private void ChangeUC(Control control)
        {
            frmMain.ChangePanel(control);
        }

        private void BtnOdjaviSe_Click(object sender, EventArgs e)
        {
            logedOut = true;
            Communication.Instance.Close();
            frmMain.Dispose();
        }

        internal void GreskaServerNijePokrenut()
        {
            MessageBox.Show("Server nije pokrenut.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
