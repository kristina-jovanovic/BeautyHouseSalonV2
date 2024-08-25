using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
	[Serializable]
	public class TipUsluge : IEntity
	{
		public int TipUslugeID { get; set; }
		public string NazivTipaUsluge { get; set; }

		public string Aliaces()
		{
			return "";
		}

		public override bool Equals(object obj)
		{
			return obj is TipUsluge usluge &&
				   //TipUslugeID == usluge.TipUslugeID &&
				   NazivTipaUsluge == usluge.NazivTipaUsluge;
		}

		public string FilterQuery(string filter)
		{
			return null;
		}

		public string FilterQueryStatus(StatusZahteva status)
		{
			return null;
		}

		public string GetById()
		{
			return null;
		}

		public async Task<List<IEntity>> GetReaderListAsync(SqlDataReader reader)
		{
			List<IEntity> tipoviUsluga = new List<IEntity>();
			while (await reader.ReadAsync())
			{
				TipUsluge tipUsluge = new TipUsluge();
				tipUsluge.TipUslugeID = (int)reader["TipUslugeID"];
				tipUsluge.NazivTipaUsluge = (string)reader["NazivTipaUsluge"];
				tipoviUsluga.Add(tipUsluge);
			}
			return tipoviUsluga;
		}

		public Task<IEntity> GetReaderResultAsync(SqlDataReader reader)
		{
			return null;
		}

		public string JoinQuery()
		{
			return "";
		}

		public string PrimaryKey()
		{
			return TipUslugeID.ToString();
		}

		public string TableName()
		{
			return "TipUsluge";
		}

		public override string ToString()
		{
			return NazivTipaUsluge;
		}

		public string UpdateQuery()
		{
			return null;
		}

		public string Values()
		{
			return $"'{NazivTipaUsluge}'";
		}
	}
}
