﻿using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Common.Communication
{
	public class Sender
	{
		NetworkStream stream;
		Socket socket;
		public Sender(Socket socket)
		{
			this.socket = socket;
			stream = new NetworkStream(socket);
		}
		public async Task SendAsync(object argument)
		{
			try
			{
				string json = JsonSerializer.Serialize(argument) + "<EOF>";
				byte[] data = System.Text.Encoding.UTF8.GetBytes(json);
				//Debug.WriteLine("Sending JSON: " + json);
				await stream.WriteAsync(data, 0, data.Length);
				await stream.FlushAsync();
				//Debug.WriteLine("///Sent///");

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
