using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading;
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
		public async Task<T> ReceiveAsync<T>()
		{
			try
			{
				using MemoryStream memoryStream = new MemoryStream();
				byte[] buffer = new byte[7168];
				int bytesRead;
				while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
				{
					string chunk = Encoding.UTF8.GetString(buffer, 0, bytesRead);
					//Debug.WriteLine($"Received chunk: {chunk}");
					if (chunk.Contains("<EOF>"))
					{
						string json = Encoding.UTF8.GetString(memoryStream.ToArray()) + chunk.Substring(0, chunk.IndexOf("<EOF>"));
						//Debug.WriteLine("Complete JSON received: " + json);
						return JsonSerializer.Deserialize<T>(json);
					}
					memoryStream.Write(buffer, 0, bytesRead);
				}
				//Debug.WriteLine("End of stream reached");
				return default(T); // No data received or end of stream

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
