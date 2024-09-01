using Client.UserControls;
using Client.UserControls.UCZahtevZaRezTermina;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using System.Net.Sockets;
using Common.Communication;
using Common.Configuration;

namespace Client.GUIControllers
{
	public class ZahtevController
	{
		private static ZahtevController instance;
		public static ZahtevController Instance
		{
			get
			{
				if (instance == null) instance = new ZahtevController();
				return instance;
			}
		}
		private ZahtevController()
		{
			configuration = new AppConfigConfiguration();
			emailSender = new EmailSender(configuration);
		}

		public delegate void ObradaDogadjaja(Control control);
		public static event ObradaDogadjaja ChangeUC;
		UCZahtev ucZahtev;
		UCZakazivanje ucZakazivanje;
		ZahtevZaRezervacijuTermina zahtev;
		BindingList<ZahtevZaRezervacijuTermina> zahtevi;
		BindingList<ZahtevZaRezervacijuTermina> zahteviZaSlanje;
		ProfilRadnika radnik;
		Usluga usluga;

		IAppConfiguration configuration;
		EmailSender emailSender;

		internal async Task ZakaziTermin()
		{
			ucZahtev = new UCZahtev();
			if (ChangeUC != null)
			{
				ChangeUC(ucZahtev);
				await PopuniComboBox();
				UcitajDgvZahteve();

				ucZahtev.CbTipUsluge.SelectedIndexChanged += CbTipUsluge_SelectedIndexChanged;
				ucZahtev.CbUsluga.SelectedIndexChanged += CbUsluga_SelectedIndexChanged;
				ucZahtev.CbRadnik.SelectedIndexChanged += CbRadnik_SelectedIndexChanged;
				ucZahtev.CbTermin.SelectedIndexChanged += CbTermin_SelectedIndexChanged;

				ucZahtev.BtnZakazi.Click += BtnZakazi_Click;
				ucZahtev.BtnDodaj.Click += BtnDodaj_Click;
				ucZahtev.BtnIzbaci.Click += BtnIzbaci_Click;
				ucZahtev.BtnIzmeni.Click += BtnIzmeni_Click;
			}
		}

		internal async Task ZakaziTermin(ProfilRadnika radnik)
		{
			this.radnik = radnik;
			await ZakaziTermin();
			//Debug.WriteLine($"{radnik},{radnik.TipUsluge}");
			//Debug.WriteLine($"{ucZahtev.CbRadnik.SelectedItem},{ucZahtev.CbTipUsluge.SelectedItem}");
			ucZahtev.CbTipUsluge.SelectedItem = radnik.TipUsluge; //ovo hoce da postavi
			ucZahtev.CbRadnik.SelectedItem = radnik; //ovo nece ?????
			ucZahtev.BtnNazad.Visible = true;
			ucZahtev.BtnNazad.Click += BtnNazad_Click;
			//Debug.WriteLine($"{radnik},{radnik.TipUsluge}");
			//Debug.WriteLine($"{ucZahtev.CbRadnik.SelectedItem},{ucZahtev.CbTipUsluge.SelectedItem}");
		}

		internal async Task ZakaziTermin(Usluga usluga)
		{
			this.usluga = usluga;
			await ZakaziTermin();
			ucZahtev.CbTipUsluge.SelectedItem = usluga.TipUsluge; //ovo hoce da postavi
			ucZahtev.CbUsluga.SelectedItem = usluga; //ovo nece ???
			ucZahtev.BtnNazad.Visible = true;
			ucZahtev.BtnNazad.Click += BtnNazad_Click1;
		}

		private void BtnNazad_Click1(object sender, EventArgs e)
		{
			UslugaController.Instance.PrikaziUslugu(usluga);
		}

		private async void BtnNazad_Click(object sender, EventArgs e)
		{
			await ProfilRadnikaController.Instance.PrikaziProfilRadnikaAsync(radnik);
		}

		private void BtnIzmeni_Click(object sender, EventArgs e)
		{
			if (IzvuciZahtev())
			{
				zahtevi.Remove(zahtev);

				ucZahtev.CbTipUsluge.SelectedItem = zahtev.Usluga.TipUsluge;
				ucZahtev.CbUsluga.SelectedItem = zahtev.Usluga;
				ucZahtev.CbRadnik.SelectedItem = zahtev.Radnik;
				ucZahtev.CbTermin.SelectedItem = zahtev.DatumIVremeTermina;
				ucZahtev.TxtNapomena.Text = zahtev.Napomena;
			}
		}

		private void UcitajDgvZahteve()
		{
			zahtevi = new BindingList<ZahtevZaRezervacijuTermina>();
			ucZahtev.DgvTermini.DataSource = zahtevi;
			ucZahtev.DgvTermini.AutoGenerateColumns = false;
			ucZahtev.DgvTermini.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			ucZahtev.DgvTermini.Columns["ZahtevID"].Visible = false;
			ucZahtev.DgvTermini.Columns["StatusZahteva"].Visible = false;
			ucZahtev.DgvTermini.Columns["Korisnik"].Visible = false;
			ucZahtev.DgvTermini.Columns["VremeKreiranja"].Visible = false;

			ucZahtev.DgvTermini.Columns["Usluga"].DisplayIndex = 0;
			ucZahtev.DgvTermini.Columns["DatumIVremeTermina"].DisplayIndex = 1;
			ucZahtev.DgvTermini.Columns["Radnik"].DisplayIndex = 2;
			ucZahtev.DgvTermini.Columns["Napomena"].DisplayIndex = 3;

			//ucZahtev.DgvTermini.Columns["Values"].Visible = false;
			//ucZahtev.DgvTermini.Columns["PrimaryKey"].Visible = false;
			//ucZahtev.DgvTermini.Columns["TableName"].Visible = false;
			//ucZahtev.DgvTermini.Columns["GetById"].Visible = false;
			//ucZahtev.DgvTermini.Columns["JoinQuery"].Visible = false;
			//ucZahtev.DgvTermini.Columns["UpdateQuery"].Visible = false;
			//ucZahtev.DgvTermini.Columns["Aliaces"].Visible = false;
		}

		private bool IzvuciZahtev()
		{
			if (ucZahtev.DgvTermini.SelectedCells.Count == 0)
			{
				MessageBox.Show("Morate odabrati zahtev iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			int rowIndex = ucZahtev.DgvTermini.SelectedCells[0].RowIndex;
			zahtev = (ZahtevZaRezervacijuTermina)ucZahtev.DgvTermini.Rows[rowIndex].DataBoundItem;
			return true;
		}

		private void BtnIzbaci_Click(object sender, EventArgs e)
		{
			if (IzvuciZahtev())
			{
				zahtevi.Remove(zahtev);
			}
		}

		private async void BtnDodaj_Click(object sender, EventArgs e)
		{
			if (IsValid())
			{
				zahtev = new ZahtevZaRezervacijuTermina();
				zahtev.Napomena = ucZahtev.TxtNapomena.Text;
				zahtev.VremeKreiranja = DateTime.Now;
				zahtev.StatusZahteva = StatusZahteva.NaCekanju;
				zahtev.DatumIVremeTermina = (DateTime)ucZahtev.CbTermin.SelectedItem;
				zahtev.Korisnik = MainController.Instance.korisnik;
				zahtev.Radnik = (ProfilRadnika)ucZahtev.CbRadnik.SelectedItem;
				zahtev.Usluga = (Usluga)ucZahtev.CbUsluga.SelectedItem;

				try
				{
					if (await Communication.Instance.ProveriRaspolozivostTerminaAsync(zahtev) == true)
					{
						zahtevi.Add(zahtev);
						ucZahtev.CbRadnik.SelectedIndex = -1;
						ucZahtev.CbUsluga.SelectedIndex = -1;
						ucZahtev.CbTermin.SelectedIndex = -1;
						ucZahtev.TxtNapomena.Text = "";
					}
					else
					{
						MessageBox.Show("Izabrani radnik je zauzet u traženom terminu.", "Neuspešno", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
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

		#region SelectedIndexChanged dogadjaji
		private void CbTermin_SelectedIndexChanged(object sender, EventArgs e)
		{
			ucZahtev.LblErrorTermin.Visible = false;
		}

		private void CbRadnik_SelectedIndexChanged(object sender, EventArgs e)
		{
			ucZahtev.LblErrorRadnik.Visible = false;
		}

		private void CbUsluga_SelectedIndexChanged(object sender, EventArgs e)
		{
			ucZahtev.LblErrorUsluga.Visible = false;
		}

		private async void CbTipUsluge_SelectedIndexChanged(object sender, EventArgs e)
		{
			ucZahtev.LblErrorTipUsluge.Visible = false;

			await RefreshUsluge();
			await RefreshRadnici();
		}
		#endregion

		private void BtnZakazi_Click(object sender, EventArgs e)
		{
			if (zahtevi.Count == 0)
			{
				MessageBox.Show("Nije unet ni jedan zahtev!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				if (Communication.Instance.KreirajZahteveZaRezTerminaAsync(zahtevi.ToList<ZahtevZaRezervacijuTermina>()) == null)
				{
					MessageBox.Show("Sistem ne može da kreira zahteve za rezervaciju termina.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					emailSender.SendEmail(zahtevi.ToList<ZahtevZaRezervacijuTermina>(), StatusZahteva.NaCekanju);
					MessageBox.Show("Sistem je kreirao zahteve za rezervaciju termina.", "Uspešno");
					zahtevi.Clear();
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

		private bool IsValid()
		{
			bool valid = true;

			if (ucZahtev.CbTipUsluge.SelectedIndex == -1)
			{
				ucZahtev.LblErrorTipUsluge.Text = "Morate izabrati tip usluge.";
				ucZahtev.LblErrorTipUsluge.Visible = true;
				valid = false;
			}
			if (ucZahtev.CbUsluga.SelectedIndex == -1)
			{
				ucZahtev.LblErrorUsluga.Text = "Morate izabrati uslugu.";
				ucZahtev.LblErrorUsluga.Visible = true;
				valid = false;
			}
			if (ucZahtev.CbRadnik.SelectedIndex == -1)
			{
				ucZahtev.LblErrorRadnik.Text = "Morate izabrati radnika.";
				ucZahtev.LblErrorRadnik.Visible = true;
				valid = false;
			}
			if (ucZahtev.CbTermin.SelectedIndex == -1)
			{
				ucZahtev.LblErrorTermin.Text = "Morate izabrati termin.";
				ucZahtev.LblErrorTermin.Visible = true;
				valid = false;
			}

			return valid;
		}

		private async Task PopuniComboBox()
		{
			try
			{
				//cb tip usluge
				List<TipUsluge> tipoviUsluge = await Communication.Instance.VratiTipoveUslugaAsync();
				ucZahtev.CbTipUsluge.DataSource = tipoviUsluge;
				//ucZahtev.CbTipUsluge.SelectedIndex = -1;

				//cb usluga
				await RefreshUsluge();
				ucZahtev.CbUsluga.SelectedIndex = -1;

				//cb radnik
				await RefreshRadnici();
				ucZahtev.CbRadnik.SelectedIndex = -1;

				//cb termin
				//radno vreme je 9-17
				int firstHour = 9;
				int lastHour = 17;
				DateTime start;
				if (DateTime.Now.Hour >= lastHour)
				{
					start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, firstHour, 0, 0);
					start = start.AddDays(1);
				}
				else
				{
					start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour + 1, 0, 0);
				}
				DateTime end = start.AddMonths(1);
				while (start < end)
				{
					while (start.Hour < firstHour)
					{
						start = start.AddHours(1);
					}
					while (start.Hour < lastHour)
					{
						ucZahtev.CbTermin.Items.Add(start);
						start = start.AddHours(1);
					}
					start = start.AddHours(16);
				}
				ucZahtev.CbTermin.FormatString = "dd.MM.yyyy. HH:mm";
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

		private async Task RefreshUsluge()
		{
			try
			{
				ucZahtev.CbUsluga.DataSource = null;
				List<Usluga> usluge = await Communication.Instance.VratiUslugeAsync(ucZahtev.CbTipUsluge.SelectedItem.ToString());
				ucZahtev.CbUsluga.DataSource = usluge;
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

		private async Task RefreshRadnici()
		{
			try
			{
				ucZahtev.CbRadnik.DataSource = null;
				List<ProfilRadnika> radnici = await Communication.Instance.VratiProfileRadnikaAsync(ucZahtev.CbTipUsluge.SelectedItem.ToString());
				ucZahtev.CbRadnik.DataSource = radnici;
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

		internal async Task PretraziZahteve()
		{
			ucZakazivanje = new UCZakazivanje();
			if (ChangeUC != null)
			{
				ucZakazivanje.BtnDodaj.Click += BtnIzaberi_Click;
				ucZakazivanje.BtnIzbaci.Click += BtnIzbaciZakazivanje_Click;
				ucZakazivanje.BtnOdobri.Click += BtnOdobri_Click;
				ucZakazivanje.BtnOdbij.Click += BtnOdbij_Click;
				await PopuniComboBoxPretrazivanje();
				ucZakazivanje.CbRadnik.SelectedIndexChanged += CbRadnikPretrazivanje_SelectedIndexChanged;
				ChangeUC(ucZakazivanje);
			}

		}

		private void BtnOdobri_Click(object sender, EventArgs e)
		{
			if (zahteviZaSlanje.Count == 0)
			{
				MessageBox.Show("Nije izabran ni jedan zahtev!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				//dodaj da li ste sigurni
				if (Communication.Instance.ZakaziTermineAsync(zahteviZaSlanje.ToList<ZahtevZaRezervacijuTermina>(), StatusZahteva.Odobren) == null)
				{
					MessageBox.Show("Sistem ne može da izvrši odobravanje zahteve.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					//SendEmail(zahteviZaSlanje.ToList<ZahtevZaRezervacijuTermina>(), StatusZahteva.Odobren);
					emailSender.SendEmail(zahteviZaSlanje.ToList<ZahtevZaRezervacijuTermina>(), StatusZahteva.Odobren);
					MessageBox.Show("Sistem je uspešno odobrio zahteve.", "Uspešno");
					RefreshDGV();
					zahteviZaSlanje.Clear();
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

		private void BtnIzbaciZakazivanje_Click(object sender, EventArgs e)
		{
			if (ucZakazivanje.DgvZahtevi.SelectedCells.Count == 0)
			{
				MessageBox.Show("Morate odabrati zahtev iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int rowIndex = ucZakazivanje.DgvZahtevi.SelectedCells[0].RowIndex;
			zahtev = (ZahtevZaRezervacijuTermina)ucZakazivanje.DgvZahtevi.Rows[rowIndex].DataBoundItem;
			//ovo mi je sve vec ucitano tako da ne moram opet u bazu

			zahteviZaSlanje.Remove(zahtev);
		}

		private void BtnOdbij_Click(object sender, EventArgs e)
		{
			if (zahteviZaSlanje.Count == 0)
			{
				MessageBox.Show("Nije izabran ni jedan zahtev!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//dodaj da li ste sigurni
			try
			{
				if (Communication.Instance.ZakaziTermineAsync(zahteviZaSlanje.ToList<ZahtevZaRezervacijuTermina>(), StatusZahteva.Odbijen) == null)
				{
					MessageBox.Show("Sistem ne može da izvrši odbijanje zahteva.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					//SendEmail(zahteviZaSlanje.ToList<ZahtevZaRezervacijuTermina>(), StatusZahteva.Odbijen);
					emailSender.SendEmail(zahteviZaSlanje.ToList<ZahtevZaRezervacijuTermina>(), StatusZahteva.Odbijen);
					MessageBox.Show("Sistem je uspešno izvršio odbijanje zahteva.", "Uspešno");
					RefreshDGV();
					zahteviZaSlanje.Clear();
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

		private async Task PopuniComboBoxPretrazivanje()
		{
			try
			{
				List<ProfilRadnika> radnici = await Communication.Instance.VratiProfileRadnikaAsync("");
				ucZakazivanje.CbRadnik.DataSource = radnici;
				await UcitajDGV();
				UcitajDgvZaSlanje();
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

		private void UcitajDgvZaSlanje()
		{
			zahteviZaSlanje = new BindingList<ZahtevZaRezervacijuTermina>();
			ucZakazivanje.DgvZahtevi.DataSource = zahteviZaSlanje;
			ucZakazivanje.DgvZahtevi.AutoGenerateColumns = false;
			ucZakazivanje.DgvZahtevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			ucZakazivanje.DgvZahtevi.Columns["ZahtevID"].Visible = false;
			ucZakazivanje.DgvZahtevi.Columns["StatusZahteva"].Visible = false;
			ucZakazivanje.DgvZahtevi.Columns["Korisnik"].Visible = false;
			ucZakazivanje.DgvZahtevi.Columns["Radnik"].Visible = false;

			ucZakazivanje.DgvZahtevi.Columns["Usluga"].DisplayIndex = 0;
			ucZakazivanje.DgvZahtevi.Columns["DatumIVremeTermina"].DisplayIndex = 1;
			ucZakazivanje.DgvZahtevi.Columns["Napomena"].DisplayIndex = 2;
			ucZakazivanje.DgvZahtevi.Columns["VremeKreiranja"].DisplayIndex = 3;

			//ucZakazivanje.DgvZahtevi.Columns["Values"].Visible = false;
			//ucZakazivanje.DgvZahtevi.Columns["PrimaryKey"].Visible = false;
			//ucZakazivanje.DgvZahtevi.Columns["TableName"].Visible = false;
			//ucZakazivanje.DgvZahtevi.Columns["GetById"].Visible = false;
			//ucZakazivanje.DgvZahtevi.Columns["JoinQuery"].Visible = false;
			//ucZakazivanje.DgvZahtevi.Columns["UpdateQuery"].Visible = false;
			//ucZakazivanje.DgvZahtevi.Columns["Aliaces"].Visible = false;
		}

		private async Task UcitajDGV()
		{
			try
			{
				zahtevi = new BindingList<ZahtevZaRezervacijuTermina>(await Communication.Instance.VratiZahteveAsync((ProfilRadnika)ucZakazivanje.CbRadnik.SelectedItem));
				ucZakazivanje.DgvPodaci.DataSource = zahtevi;
				ucZakazivanje.DgvPodaci.AutoGenerateColumns = false;
				ucZakazivanje.DgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				ucZakazivanje.DgvPodaci.Columns["ZahtevID"].Visible = false;
				ucZakazivanje.DgvPodaci.Columns["StatusZahteva"].Visible = false;
				ucZakazivanje.DgvPodaci.Columns["Korisnik"].Visible = false;
				ucZakazivanje.DgvPodaci.Columns["Radnik"].Visible = false;

				ucZakazivanje.DgvPodaci.Columns["Usluga"].DisplayIndex = 0;
				ucZakazivanje.DgvPodaci.Columns["DatumIVremeTermina"].DisplayIndex = 1;
				ucZakazivanje.DgvPodaci.Columns["Napomena"].DisplayIndex = 2;
				ucZakazivanje.DgvPodaci.Columns["VremeKreiranja"].DisplayIndex = 3;

				//ucZakazivanje.DgvPodaci.Columns["Values"].Visible = false;
				//ucZakazivanje.DgvPodaci.Columns["PrimaryKey"].Visible = false;
				//ucZakazivanje.DgvPodaci.Columns["TableName"].Visible = false;
				//ucZakazivanje.DgvPodaci.Columns["GetById"].Visible = false;
				//ucZakazivanje.DgvPodaci.Columns["JoinQuery"].Visible = false;
				//ucZakazivanje.DgvPodaci.Columns["UpdateQuery"].Visible = false;
				//ucZakazivanje.DgvPodaci.Columns["Aliaces"].Visible = false;
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

		private async void CbRadnikPretrazivanje_SelectedIndexChanged(object sender, EventArgs e)
		{
			await RefreshDGV();
		}

		private async Task RefreshDGV()
		{
			try
			{
				ucZakazivanje.DgvPodaci.DataSource = null;
				zahtevi = new BindingList<ZahtevZaRezervacijuTermina>(await Communication.Instance.VratiZahteveAsync((ProfilRadnika)ucZakazivanje.CbRadnik.SelectedItem));
				ucZakazivanje.DgvPodaci.DataSource = zahtevi;
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

		private void BtnIzaberi_Click(object sender, EventArgs e)
		{
			if (ucZakazivanje.DgvPodaci.SelectedCells.Count == 0)
			{
				MessageBox.Show("Morate odabrati zahtev iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int rowIndex = ucZakazivanje.DgvPodaci.SelectedCells[0].RowIndex;
			zahtev = (ZahtevZaRezervacijuTermina)ucZakazivanje.DgvPodaci.Rows[rowIndex].DataBoundItem;
			//ovo mi je sve vec ucitano tako da ne moram opet u bazu

			if (!zahteviZaSlanje.Contains(zahtev))
			{
				zahteviZaSlanje.Add(zahtev);
			}
		}

	}
}
