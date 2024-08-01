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
        
        public string TableName => "TipUsluge";

        public string Values => $"'{NazivTipaUsluge}'";

        public string PrimaryKey => TipUslugeID.ToString();

        public string GetById => null;

        public string JoinQuery => "";

        public string UpdateQuery => null;
        public string Aliaces => "";


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

        public override string ToString()
        {
            return NazivTipaUsluge;
        }
    }
}
