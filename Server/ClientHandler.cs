using Common.Communication;
using Common.Domain;
using Server.Exceptions;
using Server.SystemOperations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server
{
	public class ClientHandler
	{
		Sender sender;
		Receiver receiver;
		Socket socket;
		public ClientHandler(Socket socket)
		{
			sender = new Sender(socket);
			receiver = new Receiver(socket);
			this.socket = socket;
		}

		internal async Task HandleClientsAsync()
		{
			try
			{
				while (true)
				{
					Request request = await receiver.ReceiveAsync<Request>();
					Response response = await ProcessRequestAsync(request);
					await sender.SendAsync(response);
				}
			}
			catch (IOException ex)
			{
				Debug.WriteLine(">>>server>>>" + ex.Message);
			}
			catch (NullReferenceException ex)
			{
				Debug.WriteLine(">>>server>>>" + ex.Message);
			}
			catch (SerializationException ex)
			{
				Debug.WriteLine(">>>server>>>" + ex.Message);
			}
		}

		private async Task<Response> ProcessRequestAsync(Request request)
		{
			Response response = new Response();
			switch (request?.Operation)
			{
				case Operation.Login:
					Korisnik kor = Transformer.TransformisiJson<Korisnik>(request.Argument);
					try
					{
						kor = await Controller.Instance.UlogujKorisnikaAsync(kor);
						if (kor == null)
						{
							response.IsSuccessfull = false;
							response.Message = "Ne postoji to korisničko ime";
							response.Result = null;
						}
						else
						{
							response.IsSuccessfull = true;
							response.Result = kor;
						}
					}
					catch (WrongPasswordException)
					{
						response.IsSuccessfull = false;
						response.Message = "Pogrešna lozinka";
						response.Result = null;
					}
					break;
				case Operation.Registracija:
					Korisnik k = Transformer.TransformisiJson<Korisnik>(request.Argument);
					response.Result = await Controller.Instance.DodajKorisnikaAsync(k);
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}

					break;
				case Operation.VratiTipoveUsluga:
					response.Result = await Controller.Instance.UcitajListuTipovaUslugaAsync();
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.DodajUslugu:
					Usluga usluga = Transformer.TransformisiJson<Usluga>(request.Argument);
					response.Result = await Controller.Instance.KreirajNovuUsluguAsync(usluga);
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.VratiUsluge:
					response.Result = await Controller.Instance.UcitajListuUslugaAsync();
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.NadjiUslugeFilter:
					response.Result = await Controller.Instance.NadjiUslugeFilterAsync(Transformer.TransformisiJson<string>(request.Argument));
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.UcitajUslugu:
					response.Result = await Controller.Instance.UcitajUsluguAsync(Transformer.TransformisiJson<Usluga>(request.Argument));
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.IzmeniUslugu:
					response.Result = await Controller.Instance.IzmeniUsluguAsync(Transformer.TransformisiJson<Usluga>(request.Argument));
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.ObrisiUslugu:
					if (await Controller.Instance.ObrisiUsluguAsync(Transformer.TransformisiJson<Usluga>(request.Argument)))
					{
						response.IsSuccessfull = true;
					}
					else
					{
						response.IsSuccessfull = false;
					}
					break;
				case Operation.DodajProfilRadnika:
					ProfilRadnika radnik = Transformer.TransformisiJson<ProfilRadnika>(request.Argument);
					response.Result = await Controller.Instance.KreirajProfilRadnikaAsync(radnik);
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.VratiProfileRadnika:
					response.Result = await Controller.Instance.UcitajListuProfilaRadnikaAsync();
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.NadjiProfileRadnikaFilter:
					response.Result = await Controller.Instance.NadjiProfileRadnikaFilterAsync(Transformer.TransformisiJson<string>(request.Argument));
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.UcitajProfilRadnika:
					response.Result = await Controller.Instance.UcitajProfilRadnikaAsync(Transformer.TransformisiJson<ProfilRadnika>(request.Argument));
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.ProveriRaspolozivostTermina:
					response.Result = await Controller.Instance.ProveriRaspolozivostTerminaAsync(Transformer.TransformisiJson<ZahtevZaRezervacijuTermina>(request.Argument));
					if (((List<ZahtevZaRezervacijuTermina>)response.Result).Count == 0)
					{
						//znaci nije nasao takav zahtev, dostupan je
						response.IsSuccessfull = true;
					}
					else
					{
						response.IsSuccessfull = false;
					}
					break;
				case Operation.DodajZahteve:
					//ZahtevZaRezervacijuTermina zahtev = (ZahtevZaRezervacijuTermina)request.Argument;
					////probaj da nadjes sa tim radnikom i tim vremenom i odobren - proveri dostupnost OK
					List<ZahtevZaRezervacijuTermina> zahtevi = Transformer.TransformisiJson<List<ZahtevZaRezervacijuTermina>>(request.Argument);
					response.Result = await Controller.Instance.KreirajZahteveZaRezervacijuTerminaAsync(zahtevi);
					if (((List<ZahtevZaRezervacijuTermina>)response.Result).Count == 0)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.NadjiZahteveZaRadnika:
					ProfilRadnika r = Transformer.TransformisiJson<ProfilRadnika>(request.Argument);
					response.Result = await Controller.Instance.NadjiZahteveZaRezervacijuTerminaAsync(r);
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.NadjiZahteve:
					ZahtevZaRezervacijuTermina z = Transformer.TransformisiJson<ZahtevZaRezervacijuTermina>(request.Argument);
					//radnik i vreme i na cekanju OK
					response.Result = await Controller.Instance.UcitajZahteveZaRezervacijuTerminaAsync(z);
					if (response.Result == null)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.OdobriTermine:
					List<ZahtevZaRezervacijuTermina> zahteviOdobreni = Transformer.TransformisiJson<List<ZahtevZaRezervacijuTermina>>(request.Argument);
					response.Result = await Controller.Instance.ZakaziTermineAsync(zahteviOdobreni, StatusZahteva.Odobren);
					if (((List<ZahtevZaRezervacijuTermina>)response.Result).Count == 0)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
				case Operation.OdbijTermine:
					List<ZahtevZaRezervacijuTermina> zahteviOdbijeni = Transformer.TransformisiJson<List<ZahtevZaRezervacijuTermina>>(request.Argument);
					response.Result = await Controller.Instance.ZakaziTermineAsync(zahteviOdbijeni, StatusZahteva.Odbijen);
					if (((List<ZahtevZaRezervacijuTermina>)response.Result).Count == 0)
					{
						response.IsSuccessfull = false;
					}
					else
					{
						response.IsSuccessfull = true;
					}
					break;
			}
			return response;
		}
		public void Close()
		{
			socket?.Close();
		}
	}
}
