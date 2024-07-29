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
        public void Start()
        {
            osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));

            osluskujuciSoket.Bind(endPoint);
            osluskujuciSoket.Listen(1000);

            Thread nit = new Thread(OsluskujKlijente);
            nit.Start();
            nit.IsBackground = true;
        }

        private void OsluskujKlijente()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = osluskujuciSoket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket);
                    clients.Add(handler);
                    Thread nitKlijent = new Thread(handler.HandleClients);
                    nitKlijent.Start();
                    nitKlijent.IsBackground = true;
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>server>>>" + ex.Message);
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
