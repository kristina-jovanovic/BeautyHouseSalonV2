using Client.GUIControllers;
using Client.UserControls;
using Client.UserControls.UCZahtevZaRezTermina;
using Common.Communication;
using Common.Configuration;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Client
{
	public class Communication
	{
		private static Communication instance;
		public static Communication Instance
		{
			get
			{
				if (instance == null) instance = new Communication();
				return instance;
			}
		}
		private Communication() 
		{
			configuration = new AppConfigConfiguration();
		}

		IAppConfiguration configuration;
		Socket socket;
		Sender sender;
		Receiver receiver;
		Request request;
		Response response;

		private async Task ConnectAsync()
		{
			if (socket == null || !socket.Connected)
			{
				socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				await socket.ConnectAsync(configuration.GetValue("ip"), int.Parse(configuration.GetValue("port")));
				//await socket.ConnectAsync(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
				//Debug.WriteLine("KLIJENT POVEZAN");
				sender = new Sender(socket);
				receiver = new Receiver(socket);
				request = new Request();
			}
		}

		public void Close()
		{
			socket?.Close();
		}

		public async Task<Korisnik> LoginAsync(string username, string password)
		{
			try
			{
				await ConnectAsync();
				Korisnik korisnik = new Korisnik();
				korisnik.KorisnickoIme = username;
				korisnik.Lozinka = password;
				request.Operation = Operation.Login;
				request.Argument = korisnik;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<Korisnik>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		public async Task<Korisnik> RegistracijaAsync(Korisnik k)
		{
			try
			{
				await ConnectAsync();
				request.Operation = Operation.Registracija;
				request.Argument = k;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<Korisnik>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<List<TipUsluge>> VratiTipoveUslugaAsync()
		{
			try
			{
				await ConnectAsync();
				request.Operation = Operation.VratiTipoveUsluga;
				request.Argument = null;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<List<TipUsluge>>(response.Result);

				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<Usluga> KreirajNovuUsluguAsync(Usluga usluga)
		{
			try
			{
				await ConnectAsync();
				Request request = new Request();
				request.Argument = usluga;
				request.Operation = Operation.DodajUslugu;
				await sender.SendAsync(request);

				Response response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<Usluga>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		public async Task<List<Usluga>> VratiUslugeAsync(string filter)
		{
			try
			{
				await ConnectAsync();
				if (filter != "")
				{
					request.Argument = filter;
					request.Operation = Operation.NadjiUslugeFilter;
				}
				else
				{
					request.Operation = Operation.VratiUsluge;
					request.Argument = null;
				}
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<List<Usluga>>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		public async Task<Usluga> UcitajUsluguAsync(Usluga usluga)
		{
			try
			{
				await ConnectAsync();
				request.Argument = usluga;
				request.Operation = Operation.UcitajUslugu;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<Usluga>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<Usluga> IzmeniUsluguAsync(Usluga usluga)
		{
			try
			{
				await ConnectAsync();
				request.Argument = usluga;
				request.Operation = Operation.IzmeniUslugu;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<Usluga>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<bool> ObrisiUsluguAsync(Usluga usluga)
		{
			try
			{
				await ConnectAsync();
				request.Argument = usluga;
				request.Operation = Operation.ObrisiUslugu;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<ProfilRadnika> KreirajProfilRadnikaAsync(ProfilRadnika radnik)
		{
			try
			{
				await ConnectAsync();
				request.Argument = radnik;
				request.Operation = Operation.DodajProfilRadnika;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<ProfilRadnika>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<List<ProfilRadnika>> VratiProfileRadnikaAsync(string filter)
		{
			try
			{
				await ConnectAsync();
				if (filter != "")
				{
					request.Argument = filter;
					request.Operation = Operation.NadjiProfileRadnikaFilter;
				}
				else
				{
					request.Operation = Operation.VratiProfileRadnika;
					request.Argument = null;
				}
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<List<ProfilRadnika>>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<ProfilRadnika> UcitajProfilRadnikaAsync(ProfilRadnika radnik)
		{
			try
			{
				await ConnectAsync();
				request.Argument = radnik;
				request.Operation = Operation.UcitajProfilRadnika;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<ProfilRadnika>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<bool> ProveriRaspolozivostTerminaAsync(ZahtevZaRezervacijuTermina zahtev)
		{
			try
			{
				await ConnectAsync();
				request.Argument = zahtev;
				request.Operation = Operation.ProveriRaspolozivostTermina;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}
		internal async Task<List<ZahtevZaRezervacijuTermina>> KreirajZahteveZaRezTerminaAsync(List<ZahtevZaRezervacijuTermina> zahtevi)
		{
			try
			{
				await ConnectAsync();
				request.Argument = zahtevi;
				request.Operation = Operation.DodajZahteve;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<List<ZahtevZaRezervacijuTermina>>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<List<ZahtevZaRezervacijuTermina>> VratiZahteveAsync(ProfilRadnika radnik)
		{
			try
			{
				await ConnectAsync();
				request.Argument = radnik;
				request.Operation = Operation.NadjiZahteveZaRadnika;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<List<ZahtevZaRezervacijuTermina>>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<List<ZahtevZaRezervacijuTermina>> VratiZahteveAsync(ZahtevZaRezervacijuTermina zahtev)
		{
			try
			{
				await ConnectAsync();
				request.Argument = zahtev;
				request.Operation = Operation.NadjiZahteve;
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<List<ZahtevZaRezervacijuTermina>>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

		internal async Task<List<ZahtevZaRezervacijuTermina>> ZakaziTermineAsync(List<ZahtevZaRezervacijuTermina> zahtevi, StatusZahteva status)
		{
			try
			{
				await ConnectAsync();
				request.Argument = zahtevi;
				if (status == StatusZahteva.Odobren)
				{
					request.Operation = Operation.OdobriTermine;
				}
				else if (status == StatusZahteva.Odbijen)
				{
					request.Operation = Operation.OdbijTermine;
				}
				await sender.SendAsync(request);

				response = await receiver.ReceiveAsync<Response>();
				if (response.IsSuccessfull == false)
				{
					return null;
				}
				else
				{
					return Transformer.TransformisiJson<List<ZahtevZaRezervacijuTermina>>(response.Result);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
			catch (SocketException ex)
			{
				Debug.WriteLine(">>>client>>>" + ex.Message);
				throw ex;
			}
		}

	}
}
