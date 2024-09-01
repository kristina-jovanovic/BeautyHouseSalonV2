using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Configuration;

namespace DBBroker
{
	public class Broker
	{
		private readonly DBConnection connection;
		public Broker(IAppConfiguration config)
		{
			connection = new DBConnection(config);
		}

		public async Task RollbackAsync()
		{
			await Task.Run(() => connection.Rollback());
		}

		public async Task CommitAsync()
		{
			await Task.Run(() => connection.Commit());
		}

		public async Task BeginTransactionAsync()
		{
			await Task.Run(() => connection.BeginTransaction());
		}

		public async Task CloseConnectionAsync()
		{
			await connection.CloseConnectionAsync();
		}

		public async Task OpenConnectionAsync()
		{
			await connection.OpenConnectionAsync();
		}

		///
		public async Task InsertAsync(IEntity entity)
		{
			using SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"insert into {entity.TableName()} values ({entity.Values()})";
			await cmd.ExecuteNonQueryAsync();

			//Debug.WriteLine("--------INSERT USPESAN");
		}
		public async Task UpdateAsync(IEntity entity)
		{
			using SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"update {entity.TableName()} set {entity.UpdateQuery()} where {entity.PrimaryKey()}";
			await cmd.ExecuteNonQueryAsync();
		}
		public async Task DeleteAsync(IEntity entity)
		{
			using SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"delete from {entity.TableName()} where {entity.PrimaryKey()}";
			await cmd.ExecuteNonQueryAsync();
		}

		public async Task<IEntity> GetEntityByIdAsync(IEntity entity)
		{
			using SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"select *{entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.GetById()}";
			using SqlDataReader reader = await cmd.ExecuteReaderAsync();
			entity = await entity.GetReaderResultAsync(reader);
			return entity;
		}

		public async Task<List<IEntity>> GetEntitiesByIdAsync(IEntity entity, StatusZahteva status)
		{
			List<IEntity> list = new List<IEntity>();
			using SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"select *{entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.FilterQueryStatus(status)}";
			using SqlDataReader reader = await cmd.ExecuteReaderAsync();
			list = await entity.GetReaderListAsync(reader);
			return list;
		}

		public async Task<List<IEntity>> ReadAllAsync(IEntity entity)
		{
			List<IEntity> list = new List<IEntity>();
			using SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"select * from {entity.TableName()} {entity.JoinQuery()}";
			using SqlDataReader reader = await cmd.ExecuteReaderAsync();
			list = await entity.GetReaderListAsync(reader);
			return list;
		}

		public async Task<List<IEntity>> ReadAllWithFilterAsync(IEntity entity, string filter)
		{
			List<IEntity> list = new List<IEntity>();
			using SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"select *{entity.Aliaces()} from {entity.TableName()} {entity.JoinQuery()} where {entity.FilterQuery(filter)}";
			using SqlDataReader reader = await cmd.ExecuteReaderAsync();
			list = await entity.GetReaderListAsync(reader);
			return list;
		}
	}
}
