using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Common.Communication
{
    public class Receiver
    {
        NetworkStream stream;
        Socket socket;
        public Receiver(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
        }
        public async Task<object> ReceiveAsync()
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, bytesRead);
                    }
                    string json = Encoding.UTF8.GetString(ms.ToArray());
                    return JsonSerializer.Deserialize<object>(json);

                }
            }
            catch (SerializationException ex)
            {
                Debug.WriteLine(">>>receiver>>>" + ex.Message);
                throw ex;
                //return null;
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>receiver>>>" + ex.Message);
                throw ex;
                //return null;
            }
        }
    }
}
