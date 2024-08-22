﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureEF.Extensions
{
	public static class ModelBuilderExtensions
	{
		public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
		{
			foreach (var entity in modelBuilder.Model.GetEntityTypes())
			{
				entity.SetTableName(entity.DisplayName()); // ovaj kod uklanja pluralizaciju imena tabela
			}
		}
	}
}
