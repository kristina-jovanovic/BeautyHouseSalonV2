using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public string GetById => throw new NotImplementedException();

        public string JoinQuery => "";

        public string UpdateQuery => throw new NotImplementedException();
        public string Aliaces => "";


        public override bool Equals(object obj)
        {
            return obj is TipUsluge usluge &&
                   //TipUslugeID == usluge.TipUslugeID &&
                   NazivTipaUsluge == usluge.NazivTipaUsluge;
        }

        public string FilterQuery(string filter)
        {
            throw new NotImplementedException();
        }

        public string FilterQueryStatus(StatusZahteva status)
        {
            throw new NotImplementedException();
        }
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> tipoviUsluga = new List<IEntity>();
            while (reader.Read())
            {
                TipUsluge tipUsluge = new TipUsluge();
                tipUsluge.TipUslugeID = (int)reader["TipUslugeID"];
                tipUsluge.NazivTipaUsluge = (string)reader["NazivTipaUsluge"];
                tipoviUsluga.Add(tipUsluge);
            }
            return tipoviUsluga;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return NazivTipaUsluge;
        }
    }
}
