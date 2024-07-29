using Client.GUIControllers;
using Client.UserControls;
using Client.UserControls.UCZahtevZaRezTermina;
using Common.Communication;
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
        private Communication() { }

        Socket socket;
        Sender sender;
        Receiver receiver;
        Request request;
        Response response;

        private void Connect()
        {
            //try
            //{
            //    if (socket == null || !socket.Connected)
            //    {
            //        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //        socket.Connect(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
            //        //Debug.WriteLine("KLIJENT POVEZAN");
            //        sender = new Sender(socket);
            //        receiver = new Receiver(socket);
            //        request = new Request();
            //    }
            //    return true;
            //}
            //catch (SocketException)
            //{
            //    return false;
            //}

            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
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

        public Korisnik Login(string username, string password)
        {
            try
            {
                Connect();
                Korisnik korisnik = new Korisnik();
                korisnik.KorisnickoIme = username;
                korisnik.Lozinka = password;
                request.Operation = Operation.Login;
                request.Argument = korisnik;
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (Korisnik)response.Result;
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

        public Korisnik Registracija(Korisnik k)
        {
            try
            {
                Connect();
                request.Operation = Operation.Registracija;
                request.Argument = k;
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (Korisnik)response.Result;
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

        internal List<TipUsluge> VratiTipoveUsluga()
        {
            try
            {
                Connect();
                request.Operation = Operation.VratiTipoveUsluga;
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (List<TipUsluge>)response.Result;
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

        internal Usluga KreirajNovuUslugu(Usluga usluga)
        {
            try
            {
                Connect();
                Request request = new Request();
                request.Argument = usluga;
                request.Operation = Operation.DodajUslugu;
                sender.Send(request);

                Response response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (Usluga)response.Result;
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

        public List<Usluga> VratiUsluge(string filter)
        {
            try
            {
                Connect();
                if (filter != "")
                {
                    request.Argument = filter;
                    request.Operation = Operation.NadjiUslugeFilter;
                }
                else
                {
                    request.Operation = Operation.VratiUsluge;
                }
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (List<Usluga>)response.Result;
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

        public Usluga UcitajUslugu(Usluga usluga)
        {
            try
            {
                Connect();
                request.Argument = usluga;
                request.Operation = Operation.UcitajUslugu;
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (Usluga)response.Result;
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

        internal Usluga IzmeniUslugu(Usluga usluga)
        {
            try
            {
                Connect();
                request.Argument = usluga;
                request.Operation = Operation.IzmeniUslugu;
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (Usluga)response.Result;
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

        internal bool ObrisiUslugu(Usluga usluga)
        {
            try
            {
                Connect();
                request.Argument = usluga;
                request.Operation = Operation.ObrisiUslugu;
                sender.Send(request);

                response = (Response)receiver.Receive();
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

        internal ProfilRadnika KreirajProfilRadnika(ProfilRadnika radnik)
        {
            try
            {
                Connect();
                request.Argument = radnik;
                request.Operation = Operation.DodajProfilRadnika;
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (ProfilRadnika)response.Result;
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

        internal List<ProfilRadnika> VratiProfileRadnika(string filter)
        {
            try
            {
                Connect();
                if (filter != "")
                {
                    request.Argument = filter;
                    request.Operation = Operation.NadjiProfileRadnikaFilter;
                }
                else
                {
                    request.Operation = Operation.VratiProfileRadnika;
                }
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (List<ProfilRadnika>)response.Result;
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

        internal ProfilRadnika UcitajProfilRadnika(ProfilRadnika radnik)
        {
            try
            {
                Connect();
                request.Argument = radnik;
                request.Operation = Operation.UcitajProfilRadnika;
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (ProfilRadnika)response.Result;
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

        internal bool ProveriRaspolozivostTermina(ZahtevZaRezervacijuTermina zahtev)
        {
            try
            {
                Connect();
                request.Argument = zahtev;
                request.Operation = Operation.ProveriRaspolozivostTermina;
                sender.Send(request);

                response = (Response)receiver.Receive();
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
        internal List<ZahtevZaRezervacijuTermina> KreirajZahteveZaRezTermina(List<ZahtevZaRezervacijuTermina> zahtevi)
        {
            try
            {
                Connect();
                request.Argument = zahtevi;
                request.Operation = Operation.DodajZahteve;
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (List<ZahtevZaRezervacijuTermina>)response.Result;
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

        internal List<ZahtevZaRezervacijuTermina> VratiZahteve(ProfilRadnika radnik)
        {
            try
            {
                Connect();
                request.Argument = radnik;
                request.Operation = Operation.NadjiZahteveZaRadnika;
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (List<ZahtevZaRezervacijuTermina>)response.Result;
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

        internal List<ZahtevZaRezervacijuTermina> VratiZahteve(ZahtevZaRezervacijuTermina zahtev)
        {
            try
            {
                Connect();
                request.Argument = zahtev;
                request.Operation = Operation.NadjiZahteve;
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (List<ZahtevZaRezervacijuTermina>)response.Result;
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

        internal List<ZahtevZaRezervacijuTermina> ZakaziTermine(List<ZahtevZaRezervacijuTermina> zahtevi, StatusZahteva status)
        {
            try
            {
                Connect();
                request.Argument = zahtevi;
                if (status == StatusZahteva.Odobren)
                {
                    request.Operation = Operation.OdobriTermine;
                }
                else if (status == StatusZahteva.Odbijen)
                {
                    request.Operation = Operation.OdbijTermine;
                }
                sender.Send(request);

                response = (Response)receiver.Receive();
                if (response.IsSuccessfull == false)
                {
                    return null;
                }
                else
                {
                    return (List<ZahtevZaRezervacijuTermina>)response.Result;
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
