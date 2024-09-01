using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        Socket osluskujuciSoket;
        private static List<ClientHandler> clients = new List<ClientHandler>();
		private readonly Controller controller;

		public Server(Controller controller)
        {
			this.controller = controller;
		}
        public async void Start()
        {
            osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));

            osluskujuciSoket.Bind(endPoint);
            osluskujuciSoket.Listen(1000);

            await OsluskujKlijenteAsync();
        }

        private async Task OsluskujKlijenteAsync()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = await osluskujuciSoket.AcceptAsync();
                    ClientHandler handler = new ClientHandler(controller, klijentskiSoket);
                    clients.Add(handler);
                    HandleClientsAsync(handler); //ne treba await jer je ovo nova 'nit' za sebe, ne treba da cekam na njen zavrsetak
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>server>>>" + ex.Message);
            }

        }

		private async Task HandleClientsAsync(ClientHandler handler)
		{
            try
            {
                await handler.HandleClientsAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>handle clients>>>" + ex.Message);
            }
		}

		public void Stop()
        {
            osluskujuciSoket?.Close();
            foreach(ClientHandler client in clients)
            {
                client.Close();
            }
            clients.Clear();
        }
    }
}
