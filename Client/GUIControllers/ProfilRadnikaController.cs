﻿using Client.UserControls;
using Client.UserControls.UCProfilRadnika;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client.GUIControllers
{
	public class ProfilRadnikaController
	{
		private static ProfilRadnikaController instance;
		public static ProfilRadnikaController Instance
		{
			get
			{
				if (instance == null) instance = new ProfilRadnikaController();
				return instance;
			}
		}
		private ProfilRadnikaController() { }

		public delegate void ObradaDogadjaja(Control control);
		public static event ObradaDogadjaja ChangeUC;

		UCKreirajProfilRadnika ucKreirajRadnika;
		UCProfilRadnikaPrikaz ucPrikaziRadnika;
		UCPretrazivanje ucPretrazivanje;
		BindingList<ProfilRadnika> radnici;
		ProfilRadnika radnik;
		internal async Task KreirajProfilRadnika()
		{
			ucKreirajRadnika = new UCKreirajProfilRadnika();
			if (ChangeUC != null)
			{
				ChangeUC(ucKreirajRadnika);
				await PopuniComboBoxAsync();
				ucKreirajRadnika.BtnSacuvaj.Click += BtnSacuvaj_Click;
				ucKreirajRadnika.TxtIme.TextChanged += TxtIme_TextChanged;
				ucKreirajRadnika.TxtPrezime.TextChanged += TxtPrezime_TextChanged;
				ucKreirajRadnika.TxtOpis.TextChanged += TxtOpis_TextChanged;
				ucKreirajRadnika.TxtFoto.TextChanged += TxtFoto_TextChanged;
				ucKreirajRadnika.CbTipUsluge.SelectedIndexChanged += CbTipUsluge_SelectedIndexChanged;
			}
		}

		#region TextChanged dogadjaji

		private void CbTipUsluge_SelectedIndexChanged(object sender, EventArgs e)
		{
			ucKreirajRadnika.LblErrorTipUsluge.Visible = false;
		}
		private void TxtFoto_TextChanged(object sender, EventArgs e)
		{
			ucKreirajRadnika.LblErrorFoto.Visible = false;
		}

		private void TxtOpis_TextChanged(object sender, EventArgs e)
		{
			ucKreirajRadnika.LblErrorOpis.Visible = false;
		}

		private void TxtPrezime_TextChanged(object sender, EventArgs e)
		{
			ucKreirajRadnika.LblErrorPrezime.Visible = false;
		}

		private void TxtIme_TextChanged(object sender, EventArgs e)
		{
			ucKreirajRadnika.LblErrorIme.Visible = false;
		}
		#endregion
		private async Task PopuniComboBoxAsync()
		{
			try
			{
				List<TipUsluge> tipoviUsluga = await Communication.Instance.VratiTipoveUslugaAsync();
				ucKreirajRadnika.CbTipUsluge.DataSource = tipoviUsluga;
				ucKreirajRadnika.CbTipUsluge.SelectedIndex = -1;
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

		private async void BtnSacuvaj_Click(object sender, EventArgs e)
		{
			if (IsValid())
			{
				ProfilRadnika r = new ProfilRadnika();
				r.Ime = ucKreirajRadnika.TxtIme.Text;
				r.Prezime = ucKreirajRadnika.TxtPrezime.Text;
				r.Opis = ucKreirajRadnika.TxtOpis.Text;
				r.TipUsluge = (TipUsluge)ucKreirajRadnika.CbTipUsluge.SelectedItem;
				//r.Fotografija = KonvertujFotografiju();
				r.Fotografija = ucKreirajRadnika.TxtFoto.Text;

				try
				{
					radnik = await Communication.Instance.KreirajProfilRadnikaAsync(r);
					if (radnik == null)
					{
						MessageBox.Show("Sistem ne može da kreira profil radnika.", "Greška");
					}
					else
					{
						MessageBox.Show("Sistem je kreirao profil radnika.", "Uspešno");
						ucKreirajRadnika.TxtIme.Text = "";
						ucKreirajRadnika.TxtPrezime.Text = "";
						ucKreirajRadnika.TxtOpis.Text = "";
						ucKreirajRadnika.TxtFoto.Text = "";
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
		}

		private async Task PostaviRadnikaAsync(ProfilRadnika radnik)
		{
			await LoadImageAsync(radnik.Fotografija);
			ucPrikaziRadnika.LblImePrezime.Text = $"{radnik.Ime} {radnik.Prezime}";
			ucPrikaziRadnika.LblTipUsluge.Text = $"Tip usluge: {radnik.TipUsluge.NazivTipaUsluge}";
			ucPrikaziRadnika.TxtOpis.Text = radnik.Opis;
		}

		private async Task LoadImageAsync(string url)
		{
			using HttpClient client = new HttpClient();
			try
			{
				var stream = await client.GetStreamAsync(url);
				Image image = System.Drawing.Image.FromStream(stream);
				image = ResizeImage(image, 249, 193);
				ucPrikaziRadnika.PbFoto.Image = image;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading image: {ex.Message}");
			}

		}

		static Image ResizeImage(Image originalImage, int newWidth, int newHeight)
		{
			// stvaranje nove slike s novom veličinom
			Bitmap resizedImage = new Bitmap(newWidth, newHeight);

			using (Graphics g = Graphics.FromImage(resizedImage))
			{
				g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
				g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
			}

			return resizedImage;
		}

		private bool IsValid()
		{
			bool valid = true;
			Regex regexImePrezime = new Regex(@"^[A-Z][a-z]+(\s[A-Z][a-z]+)*$");

			if (string.IsNullOrEmpty(ucKreirajRadnika.TxtIme.Text) || !regexImePrezime.IsMatch(ucKreirajRadnika.TxtIme.Text))
			{
				ucKreirajRadnika.LblErrorIme.Text = "Morate uneti ime radnika ispravno.";
				ucKreirajRadnika.LblErrorIme.Visible = true;
				valid = false;
			}
			if (string.IsNullOrEmpty(ucKreirajRadnika.TxtPrezime.Text) || !regexImePrezime.IsMatch(ucKreirajRadnika.TxtPrezime.Text))
			{
				ucKreirajRadnika.LblErrorPrezime.Text = "Morate uneti prezime radnika ispravno.";
				ucKreirajRadnika.LblErrorPrezime.Visible = true;
				valid = false;
			}
			if (string.IsNullOrEmpty(ucKreirajRadnika.TxtOpis.Text))
			{
				ucKreirajRadnika.LblErrorOpis.Text = "Morate uneti opis radnika.";
				ucKreirajRadnika.LblErrorOpis.Visible = true;
				valid = false;
			}
			if (ucKreirajRadnika.CbTipUsluge.SelectedIndex == -1)
			{
				ucKreirajRadnika.LblErrorTipUsluge.Text = "Morate izabrati tip usluge.";
				ucKreirajRadnika.LblErrorTipUsluge.Visible = true;
				valid = false;
			}
			if (string.IsNullOrEmpty(ucKreirajRadnika.TxtFoto.Text))
			{
				ucKreirajRadnika.LblErrorFoto.Text = "Morate izabrati fotografiju.";
				ucKreirajRadnika.LblErrorFoto.Visible = true;
				valid = false;
			}

			return valid;
		}

		internal async Task PretraziProfileRadnika()
		{
			ucPretrazivanje = new UCPretrazivanje();
			ucPretrazivanje.GroupBox1.Text = "Pretraživanje radnika";
			ucPretrazivanje.BtnIzaberi.Text = "Izaberi radnika";
			if (ChangeUC != null)
			{
				ucPretrazivanje.BtnIzaberi.Click += BtnIzaberi_Click;
				ucPretrazivanje.TxtPretraga.TextChanged += TxtPretraga_TextChanged;
				ChangeUC(ucPretrazivanje);
				await UcitajDGV();
			}
		}

		private async void TxtPretraga_TextChanged(object sender, EventArgs e)
		{
			try
			{
				ucPretrazivanje.DgvPodaci.DataSource = null;
				radnici = new BindingList<ProfilRadnika>(await Communication.Instance.VratiProfileRadnikaAsync(ucPretrazivanje.TxtPretraga.Text));
				ucPretrazivanje.DgvPodaci.DataSource = radnici;
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

		private async Task UcitajDGV()
		{
			try
			{
				radnici = new BindingList<ProfilRadnika>(await Communication.Instance.VratiProfileRadnikaAsync(ucPretrazivanje.TxtPretraga.Text));
				ucPretrazivanje.DgvPodaci.DataSource = radnici;
				ucPretrazivanje.DgvPodaci.AutoGenerateColumns = false;
				ucPretrazivanje.DgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				ucPretrazivanje.DgvPodaci.Columns["RadnikID"].Visible = false;
				ucPretrazivanje.DgvPodaci.Columns["Opis"].Visible = false;
				ucPretrazivanje.DgvPodaci.Columns["Fotografija"].Visible = false;
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

		private async void BtnIzaberi_Click(object sender, EventArgs e)
		{
			if (ucPretrazivanje.DgvPodaci.SelectedCells.Count == 0)
			{
				MessageBox.Show("Morate odabrati radnika iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int rowIndex = ucPretrazivanje.DgvPodaci.SelectedCells[0].RowIndex;
			radnik = (ProfilRadnika)ucPretrazivanje.DgvPodaci.Rows[rowIndex].DataBoundItem;

			try
			{
				radnik = await Communication.Instance.UcitajProfilRadnikaAsync(radnik);
				if (radnik == null)
				{
					MessageBox.Show("Sistem ne može da učita profil radnika.", "Greška");
					return;
				}
				await PrikaziProfilRadnikaAsync(radnik);
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

		internal async Task PrikaziProfilRadnikaAsync(ProfilRadnika radnik)
		{
			if (ChangeUC != null)
			{
				ucPrikaziRadnika = new UCProfilRadnikaPrikaz();
				if (MainController.Instance.korisnik.Vlasnik == false)
				{
					ucPrikaziRadnika.BtnZakazi.Visible = true;
					ucPrikaziRadnika.BtnZakazi.Click += BtnZakazi_Click;
				}
				await PostaviRadnikaAsync(radnik);
				ucPrikaziRadnika.BtnNazad.Click += BtnNazad_Click;
				ChangeUC(ucPrikaziRadnika);
			}
		}

		private async void BtnZakazi_Click(object sender, EventArgs e)
		{
			await ZahtevController.Instance.ZakaziTermin(radnik);
		}

		private void BtnNazad_Click(object sender, EventArgs e)
		{
			if (ChangeUC != null)
			{
				ChangeUC(ucPretrazivanje);
			}
		}
	}
}
