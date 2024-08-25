using Common.Domain;
using DataAccessLayer;
using DataAccessLayer.Repositories.DBBroker;
using DBBroker;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
	public static class Program
	{
		public static IServiceProvider ServiceProvider { get; private set; }
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var services = new ServiceCollection();

			services.AddScoped<Broker>(); // Registracija Brokera
			services.AddScoped<IRepository<IEntity>>(provider =>
			{
				//var broker = provider.GetRequiredService<Broker>();
				return new RepositoryDBB(provider.GetRequiredService<Broker>());
			});
			ServiceProvider = services.BuildServiceProvider();
			Controller.Initialize(ServiceProvider);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmServer());
		}
	}
}
