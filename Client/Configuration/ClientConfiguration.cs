using Common.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Configuration
{
	public class ClientConfiguration : IAppConfiguration
	{
		public string GetValue(string key)
		{
			return ConfigurationManager.AppSettings[key];
		}
	}
}
