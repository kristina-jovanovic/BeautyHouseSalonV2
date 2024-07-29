﻿using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DBBroker
{
	public class DBConnection
	{
		private SqlConnection connection;
		private SqlTransaction transaction;

		public DBConnection()
		{
			connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BeautyHouseBaza"].ConnectionString);
		}

		public async Task OpenConnectionAsync()
		{
			if (connection.State != ConnectionState.Open)
			{
				await connection?.OpenAsync();
			}
		}

		public async Task CloseConnectionAsync()
		{
			if (connection.State != ConnectionState.Closed)
			{
				await connection?.CloseAsync();
			}
		}

		public void BeginTransaction()
		{
			transaction = connection.BeginTransaction();
		}
		public void Commit()
		{
			transaction?.Commit();
		}
		public void Rollback()
		{
			transaction.Rollback();
		}
		public SqlCommand CreateCommand()
		{
			return new SqlCommand("", connection, transaction);
		}
	}
}
