using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Configuration
{
	public class AppConfigConfiguration : IAppConfiguration
	{
		public string GetConnectionString(string key)
		{
			return ConfigurationManager.ConnectionStrings[key].ConnectionString;
		}

		public string GetValue(string key)
		{
			return ConfigurationManager.AppSettings[key];
		}
	}
}
