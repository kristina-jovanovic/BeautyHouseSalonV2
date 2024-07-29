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

        internal void HandleClients()
        {
            try
            {
                while (true)
                {
                    Request request = (Request)receiver.Receive();
                    Response response = ProcessRequest(request);
                    sender.Send(response);
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

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            switch (request.Operation)
            {
                case Operation.Login:
                    Korisnik kor = (Korisnik)request.Argument;
                    try
                    {
                        kor = Controller.Instance.UlogujKorisnika(kor);
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
                    Korisnik k = (Korisnik)request.Argument;
                    response.Result = Controller.Instance.DodajKorisnika(k);
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
                    response.Result = Controller.Instance.UcitajListuTipovaUsluga();
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
                    Usluga usluga = (Usluga)request.Argument;
                    response.Result = Controller.Instance.KreirajNovuUslugu(usluga);
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
                    response.Result = Controller.Instance.UcitajListuUsluga();
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
                    response.Result = Controller.Instance.NadjiUslugeFilter((string)request.Argument);
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
                    response.Result = Controller.Instance.UcitajUslugu((Usluga)request.Argument);
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
                    response.Result = Controller.Instance.IzmeniUslugu((Usluga)request.Argument);
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
                    if (Controller.Instance.ObrisiUslugu((Usluga)request.Argument))
                    {
                        response.IsSuccessfull = true;
                    }
                    else
                    {
                        response.IsSuccessfull = false;
                    }
                    break;
                case Operation.DodajProfilRadnika:
                    ProfilRadnika radnik = (ProfilRadnika)request.Argument;
                    response.Result = Controller.Instance.KreirajProfilRadnika(radnik);
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
                    response.Result = Controller.Instance.UcitajListuProfilaRadnika();
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
                    response.Result = Controller.Instance.NadjiProfileRadnikaFilter((string)request.Argument);
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
                    response.Result = Controller.Instance.UcitajProfilRadnika((ProfilRadnika)request.Argument);
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
                    response.Result = Controller.Instance.ProveriRaspolozivostTermina((ZahtevZaRezervacijuTermina)request.Argument);
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
                    List<ZahtevZaRezervacijuTermina> zahtevi = (List<ZahtevZaRezervacijuTermina>)request.Argument;
                    response.Result = Controller.Instance.KreirajZahteveZaRezervacijuTermina(zahtevi);
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
                    ProfilRadnika r = (ProfilRadnika)request.Argument;
                    response.Result = Controller.Instance.NadjiZahteveZaRezervacijuTermina(r);
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
                    ZahtevZaRezervacijuTermina z = (ZahtevZaRezervacijuTermina)request.Argument;
                    //radnik i vreme i na cekanju OK
                    response.Result = Controller.Instance.UcitajZahteveZaRezervacijuTermina(z);
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
                    List<ZahtevZaRezervacijuTermina> zahteviOdobreni = (List<ZahtevZaRezervacijuTermina>)request.Argument;
                    response.Result = Controller.Instance.ZakaziTermine(zahteviOdobreni, StatusZahteva.Odobren);
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
                    List<ZahtevZaRezervacijuTermina> zahteviOdbijeni = (List<ZahtevZaRezervacijuTermina>)request.Argument;
                    response.Result = Controller.Instance.ZakaziTermine(zahteviOdbijeni, StatusZahteva.Odbijen);
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
