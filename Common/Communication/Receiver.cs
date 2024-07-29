using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common.Communication
{
    public class Receiver
    {
        NetworkStream stream;
        BinaryFormatter formatter;
        Socket socket;
        public Receiver(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }
        public object Receive()
        {
            try
            {
                return formatter.Deserialize(stream);
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
