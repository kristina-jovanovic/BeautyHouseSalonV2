using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Configuration
{
	public class WebApiConfiguration : IAppConfiguration
	{
		private readonly IConfiguration configuration;

		public WebApiConfiguration(IConfiguration configuration)
		{
			this.configuration = configuration;
		}

		public string GetConnectionString(string key)
		{
			return configuration.GetConnectionString(key);
		}

		public string GetValue(string key)
		{
			return configuration[key];
		}
	}
}
