using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common.Communication
{
    public class Sender
    {
        NetworkStream stream;
        BinaryFormatter formatter;
        Socket socket;
        public Sender(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }
        public void Send(object argument)
        {
            try
            {
                formatter.Serialize(stream, argument);
            }
            catch (SerializationException ex)
            {
                Debug.WriteLine(">>>sender>>>" + ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>sender>>>" + ex.Message);
            }
        }
    }
}
