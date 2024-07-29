using Client.Forms;
using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
    internal class LoginController
    {
        private static LoginController instance;
        public static LoginController Instance
        {
            get
            {
                if (instance == null) instance = new LoginController();
                return instance;
            }
        }
        private LoginController()
        {
            frmLogin = new FrmLogin();
            ucLogin = new UCLogin();
            ucReg = new UCRegistracija();
            korisnik = new Korisnik();
        }

        FrmLogin frmLogin;
        UCLogin ucLogin;
        UCRegistracija ucReg;
        Korisnik korisnik;

        private enum TipProvere
        {
            Login,
            Registracija
        }

        public void ShowFrmLogin()
        {
            frmLogin.ChangePanel(ucLogin);
            ucLogin.BtnPrijava.Click += BtnPrijava_Click;
            ucLogin.BtnRegistracija.Click += BtnRegistracija_Click;
            ucLogin.TxtKorisnickoIme.TextChanged += TxtKorisnickoImeLogin_TextChanged;
            ucLogin.TxtLozinka.TextChanged += TxtLozinkaLogin_TextChanged;
            frmLogin.ShowDialog();
        }
        public void ShowFrmMain()
        {
            frmLogin.Visible = false;
            MainController.Instance.ShowFrmMain(korisnik);
            if (MainController.Instance.logedOut)
            {
                frmLogin.ChangePanel(ucLogin);
                ucLogin.TxtKorisnickoIme.Text = "";
                ucLogin.TxtLozinka.Text = "";
                frmLogin.Visible = true;
            }
            else
            {
                frmLogin.Dispose();
            }
        }
        private void BtnRegistracija_Click(object sender, EventArgs e)
        {
            IsprazniPanelReg();
            frmLogin.ChangePanel(ucReg);
            ucReg.BtnOtkazi.Click += BtnOtkazi_Click;
            ucReg.BtnRegistrujSe.Click += BtnRegistrujSe_Click;
            ucReg.TxtIme.TextChanged += TxtIme_TextChanged;
            ucReg.TxtPrezime.TextChanged += TxtPrezime_TextChanged;
            ucReg.TxtBrTel.TextChanged += TxtBrTel_TextChanged;
            ucReg.TxtEmail.TextChanged += TxtEmail_TextChanged;
            ucReg.TxtKorisnickoIme.TextChanged += TxtKorisnickoImeReg_TextChanged;
            ucReg.TxtLozinka.TextChanged += TxtLozinkaReg_TextChanged;
            ucReg.DtpDatumRodj.ValueChanged += DtpDatumRodj_ValueChanged;
        }

        private void IsprazniPanelReg()
        {
            ucReg.TxtIme.Text = "";
            ucReg.TxtPrezime.Text = "";
            ucReg.TxtBrTel.Text = "";
            ucReg.TxtEmail.Text = "";
            ucReg.TxtKorisnickoIme.Text = "";
            ucReg.TxtLozinka.Text = "";
            ucReg.DtpDatumRodj.Value = DateTime.Now;
        }

        private void BtnRegistrujSe_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid(TipProvere.Registracija))
                {
                    Korisnik kor = new Korisnik();
                    kor.Ime = ucReg.TxtIme.Text;
                    kor.Prezime = ucReg.TxtPrezime.Text;
                    kor.BrojTelefona = ucReg.TxtBrTel.Text;
                    kor.Email = ucReg.TxtEmail.Text;
                    kor.KorisnickoIme = ucReg.TxtKorisnickoIme.Text;
                    byte[] salt = HashFunction.GenerateCode();
                    kor.KodZaEnkripciju = Convert.ToBase64String(salt);
                    kor.Lozinka = HashFunction.HashPassword(ucReg.TxtLozinka.Text, salt);
                    kor.DatumRodjenja = ucReg.DtpDatumRodj.Value;
                    kor.Vlasnik = false;

                    korisnik = Communication.Instance.Registracija(kor);

                    if (korisnik == null)
                    {
                        MessageBox.Show("Sistem ne može da kreira korisnički nalog.\nUneto korisničko ime je već zauzeto!\nPokušaj ponovo!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ucReg.LblErrorUsername.Text = "Korisničko ime je zauzeto.";
                        ucReg.LblErrorUsername.Visible = true;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sistem je kreirao korisnički nalog.\nUspešno ste se registrovali!", "Registracija");
                        ShowFrmMain();
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
        private void BtnOtkazi_Click(object sender, EventArgs e)
        {
            ucReg.LblErrorIme.Visible = false;
            ucReg.LblErrorPrezime.Visible = false;
            ucReg.LblErrorBrTel.Visible = false;
            ucReg.LblErrorEmail.Visible = false;
            ucReg.LblErrorUsername.Visible = false;
            ucReg.LblErrorPassword.Visible = false;
            ucReg.LblErrorDatumRodj.Visible = false;
            frmLogin.ChangePanel(ucLogin);
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid(TipProvere.Login))
                {
                    korisnik = Communication.Instance.Login(ucLogin.TxtKorisnickoIme.Text, ucLogin.TxtLozinka.Text);

                    if (korisnik == null)
                    {
                        MessageBoxManager.Cancel = "Registruj se";
                        MessageBoxManager.OK = "Prijavi se";
                        MessageBoxManager.Register();
                        DialogResult result = MessageBox.Show("Neuspešno prijavljivanje.\nPogrešno uneti kredencijali! \nUkoliko nemaš nalog, registruj se!", "Greška", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (result == DialogResult.Cancel)
                        {
                            ucLogin.BtnRegistracija.PerformClick();
                        }
                        MessageBoxManager.Unregister();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Uspešno ste se prijavili!", "Uspešna prijava");
                        ShowFrmMain();
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

        private bool IsValid(TipProvere tip)
        {
            bool valid = true;

            if (tip == TipProvere.Login)
            {
                if (string.IsNullOrEmpty(ucLogin.TxtKorisnickoIme.Text))
                {
                    ucLogin.LblErrorUsername.Text = "Morate uneti korisničko ime.";
                    ucLogin.LblErrorUsername.Visible = true;
                    valid = false;
                }
                if (string.IsNullOrEmpty(ucLogin.TxtLozinka.Text))
                {
                    ucLogin.LblErrorPassword.Text = "Morate uneti lozinku.";
                    ucLogin.LblErrorPassword.Visible = true;
                    valid = false;
                }
            }
            else
            {
                Regex regexImePrezime = new Regex(@"^[A-Z][a-z]+(\s[A-Z][a-z]+)*$");
                Regex regexBrTel = new Regex(@"^06\d{8}$");
                Regex regexEmail = new Regex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

                if (string.IsNullOrEmpty(ucReg.TxtIme.Text) || !regexImePrezime.IsMatch(ucReg.TxtIme.Text))
                {
                    ucReg.LblErrorIme.Text = "Morate uneti ime gramatički ispravno.";
                    ucReg.LblErrorIme.Visible = true;
                    valid = false;
                }
                if (string.IsNullOrEmpty(ucReg.TxtPrezime.Text) || !regexImePrezime.IsMatch(ucReg.TxtPrezime.Text))
                {
                    ucReg.LblErrorPrezime.Text = "Morate uneti prezime gramatički ispravno.";
                    ucReg.LblErrorPrezime.Visible = true;
                    valid = false;
                }
                if (string.IsNullOrEmpty(ucReg.TxtBrTel.Text) || !regexBrTel.IsMatch(ucReg.TxtBrTel.Text))
                {
                    ucReg.LblErrorBrTel.Text = "Morate uneti broj telefona u formatu 06xxxxxxxx.";
                    ucReg.LblErrorBrTel.Visible = true;
                    valid = false;
                }
                if (string.IsNullOrEmpty(ucReg.TxtEmail.Text) || !regexEmail.IsMatch(ucReg.TxtEmail.Text))
                {
                    ucReg.LblErrorEmail.Text = "Morate uneti email adresu u ispravnom formatu.";
                    ucReg.LblErrorEmail.Visible = true;
                    valid = false;
                }
                if (string.IsNullOrEmpty(ucReg.TxtKorisnickoIme.Text) || ucReg.TxtKorisnickoIme.Text.Length < 4)
                {
                    ucReg.LblErrorUsername.Text = "Morate uneti korisničko ime od barem 4 karaktera.";
                    ucReg.LblErrorUsername.Visible = true;
                    valid = false;
                }
                if (string.IsNullOrEmpty(ucReg.TxtLozinka.Text) || ucReg.TxtLozinka.Text.Length < 4)
                {
                    ucReg.LblErrorPassword.Text = "Morate uneti lozinku od barem 4 karaktera.";
                    ucReg.LblErrorPassword.Visible = true;
                    valid = false;
                }
                if (DateTime.ParseExact(ucReg.DtpDatumRodj.Value.ToString("dd.MM.yyyy."), "dd.MM.yyyy.", CultureInfo.InvariantCulture) > DateTime.Now.AddYears(-12))
                {
                    ucReg.LblErrorDatumRodj.Text = "Morate imati više od 12 godina da biste se registrovali.";
                    ucReg.LblErrorDatumRodj.Visible = true;
                    valid = false;
                }
            }
            return valid;
        }

        #region TextChanged Events
        private void DtpDatumRodj_ValueChanged(object sender, EventArgs e)
        {
            ucReg.LblErrorDatumRodj.Visible = false;
        }

        private void TxtLozinkaReg_TextChanged(object sender, EventArgs e)
        {
            ucReg.LblErrorPassword.Visible = false;
        }

        private void TxtKorisnickoImeReg_TextChanged(object sender, EventArgs e)
        {
            ucReg.LblErrorUsername.Visible = false;
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            ucReg.LblErrorEmail.Visible = false;
        }

        private void TxtBrTel_TextChanged(object sender, EventArgs e)
        {
            ucReg.LblErrorBrTel.Visible = false;
        }

        private void TxtPrezime_TextChanged(object sender, EventArgs e)
        {
            ucReg.LblErrorPrezime.Visible = false;
        }

        private void TxtIme_TextChanged(object sender, EventArgs e)
        {
            ucReg.LblErrorIme.Visible = false;
        }

        private void TxtLozinkaLogin_TextChanged(object sender, EventArgs e)
        {
            ucLogin.LblErrorPassword.Visible = false;
        }

        private void TxtKorisnickoImeLogin_TextChanged(object sender, EventArgs e)
        {
            ucLogin.LblErrorUsername.Visible = false;
        }
        #endregion

    }

}
