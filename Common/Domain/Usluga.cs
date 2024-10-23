using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
	[Serializable]
	public class Usluga : IEntity
	{
		public int UslugaID { get; set; }
		public string Naziv { get; set; }
		public double Cena { get; set; }
		public int TrajanjeUMinutima { get; set; }
		public string FotografijaUsluge { get; set; } = "";
		public TipUsluge TipUsluge { get; set; }

		public string Aliaces()
		{
			return "";
		}

		public override bool Equals(object obj)
		{
			return obj is Usluga usluga &&
				   //UslugaID == usluga.UslugaID && //ovo sam sad zakom.
				   Naziv == usluga.Naziv;
		}

		public string FilterQuery(string filter)
		{
			return $"lower(naziv) like concat('%',lower('{filter}'),'%')" +
				$"or TipUsluge in (select TipUslugeID from TipUsluge where lower(NazivTipaUsluge) like concat(lower('{filter}'),'%'))";
		}
		public string FilterQueryStatus(StatusZahteva status)
		{
			return null;
		}

		public string GetById()
		{
			return $"Naziv='{Naziv}' OR UslugaID={UslugaID}";
		}

		public async Task<List<IEntity>> GetReaderListAsync(SqlDataReader reader)
		{
			List<IEntity> usluge = new List<IEntity>();
			while (await reader.ReadAsync())
			{
				usluge.Add(ReadFromReader(reader));
			}
			return usluge;
		}

		public async Task<IEntity> GetReaderResultAsync(SqlDataReader reader)
		{
			if (await reader.ReadAsync())
			{
				return ReadFromReader(reader);
			}
			else
			{
				return null;
			}
		}

		public string JoinQuery()
		{
			return "u JOIN TipUsluge tu ON u.TipUsluge=tu.TipUslugeID";
		}

		public string PrimaryKey()
		{
			return $"UslugaID={UslugaID}";
		}

		public string TableName()
		{
			return "Usluga";
		}

		public override string ToString()
		{
			return Naziv;
		}

		public string UpdateQuery()
		{
			return $"Naziv='{Naziv}', Cena={Cena}, TrajanjeUMinutima={TrajanjeUMinutima}, FotografijaUsluge='{FotografijaUsluge}', TipUsluge={TipUsluge.TipUslugeID}";
		}

		public string Values()
		{
			return $"'{Naziv}', {Cena}, {TrajanjeUMinutima}, '{FotografijaUsluge}', {TipUsluge.TipUslugeID}";
		}

		private IEntity ReadFromReader(SqlDataReader reader)
		{
			Usluga usluga = new Usluga();
			usluga.UslugaID = (int)reader["UslugaID"];
			usluga.Naziv = (string)reader["Naziv"];
			usluga.Cena = (double)reader["Cena"];
			usluga.TrajanjeUMinutima = (int)reader["TrajanjeUMinutima"];
			usluga.FotografijaUsluge = (string)reader["FotografijaUsluge"];
			usluga.TipUsluge = new TipUsluge
			{
				TipUslugeID = (int)reader["TipUslugeID"],
				NazivTipaUsluge = (string)reader["NazivTipaUsluge"]
			};
			return usluga;
		}
	}
}
