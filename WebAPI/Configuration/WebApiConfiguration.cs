using Common.Configuration;

namespace WebAPI.Configuration
{
	public class WebApiConfiguration : IAppConfiguration
	{
		private readonly IConfiguration configuration;

		public WebApiConfiguration(IConfiguration configuration)
		{
			this.configuration = configuration;
		}

		public string GetValue(string key)
		{
			return configuration[key];
		}
	}
}
