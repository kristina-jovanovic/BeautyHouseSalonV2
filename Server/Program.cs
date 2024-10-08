﻿using Common.Configuration;
using Common.Domain;
using DataAccessLayer;
using DataAccessLayer.Repositories.DBBroker;
using DBBroker;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
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

			services.AddSingleton<IAppConfiguration, AppConfigConfiguration>();
			services.AddScoped<Broker>((provider) =>
			{
				return new Broker(provider.GetRequiredService<IAppConfiguration>());
			}); // Registracija Brokera

			services.AddScoped<IRepository<IEntity>>(provider =>
			{
				//var broker = provider.GetRequiredService<Broker>();
				return new RepositoryDBB(provider.GetRequiredService<Broker>());
			});

			services.AddScoped<Controller>();
			ServiceProvider = services.BuildServiceProvider();
			//Controller.Initialize(ServiceProvider);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmServer(ServiceProvider.GetRequiredService<Controller>()));
		}
	}
}
