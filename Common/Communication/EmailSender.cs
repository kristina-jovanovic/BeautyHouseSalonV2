using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;
using Common.Configuration;

namespace Common.Communication
{
	public class EmailSender
	{
		private readonly IAppConfiguration appConfiguration;

		public EmailSender(IAppConfiguration appConfiguration)
		{
			this.appConfiguration = appConfiguration;
		}
		public void SendEmail(List<ZahtevZaRezervacijuTermina> zahtevi, StatusZahteva status)
		{
			try
			{
				MailMessage message = new MailMessage();
				SmtpClient smtp = new SmtpClient();

				//smtp.Port = int.Parse(ConfigurationManager.AppSettings["portSmtp"]);
				smtp.Port = int.Parse(appConfiguration.GetValue("PortSmtp"));
				//smtp.Host = ConfigurationManager.AppSettings["hostSmtp"];
				smtp.Host = appConfiguration.GetValue("HostSmtp");
				smtp.EnableSsl = true;
				smtp.UseDefaultCredentials = false;
				smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
				//smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["salonEmail"], ConfigurationManager.AppSettings["salonPass"]);
				smtp.Credentials = new NetworkCredential(appConfiguration.GetValue("SalonEmail"), appConfiguration.GetValue("SalonPass"));
				message.From = new MailAddress(appConfiguration.GetValue("SalonEmail"));

				if (status == StatusZahteva.NaCekanju)
				{
					//tek poslat zahtev -> salje se vlasniku, njemu stize jedan mejl sa svim zahtevima jednog korisnika
					message.To.Add(new MailAddress(appConfiguration.GetValue("VlasnikEmail"))); //vlasnik
					message.Subject = "BeautyHouse zahtev za rezervaciju";
					message.Body = $"Poštovana {appConfiguration.GetValue("VlasnikIme")}, \n\nPristigao je novi zahtev za rezervaciju termina!\n\n";
					foreach (ZahtevZaRezervacijuTermina z in zahtevi)
					{
						message.Body += $"{z.ToString()}\n\n";
					}
					message.Body += "BeautyHouse ©";
					smtp.Send(message);
				}
				else
				{
					foreach (ZahtevZaRezervacijuTermina z in zahtevi)
					{
						//ovo je odobren/odbijen zahtev -> salje se korisniku, posto je moguce i verovatno da ce vlasnik 
						//zajedno odobriti/odbiti zahteve razlicitih korisnika, svakom se salje pojedinacni mejl,
						//pa cak i ako ima zahteva od istog korisnika
						message.To.Add(new MailAddress(z.Korisnik.Email));
						message.Subject = "BeautyHouse rezervacija";
						message.Body = $"Poštovana {z.Korisnik.Ime},\n\n";
						if (status == StatusZahteva.Odobren)
						{
							message.Body += "Vaš zahtev za rezervaciju termina je odobren!\n";
						}
						else
						{
							message.Body += "Vaš zahtev za rezervaciju termina je odbijen zbog prebukiranosti!\n";
						}
						message.Body += $"{z.ToString()}\n\n";
						message.Body += "BeautyHouse ©";
						smtp.Send(message);
					}
				}
			}
			catch (Exception)
			{
				Debug.WriteLine("------------ Greska prilikom slanja email-a ----------");
			}

		}

	}
}

