using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class ProfilRadnika : IEntity
    {
        public int RadnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Opis { get; set; }
        public byte[] Fotografija { get; set; }
        public TipUsluge TipUsluge { get; set; }

        public string TableName => "ProfilRadnika";

        public string Values => $"'{Ime}', '{Prezime}', '{Opis}', 0x{BitConverter.ToString(Fotografija).Replace("-", "")}, {TipUsluge.TipUslugeID}";

        public string PrimaryKey => RadnikID.ToString();

        public string GetById => $"Ime='{Ime}' and Prezime='{Prezime}'";

        public string JoinQuery => "pr JOIN TipUsluge tu ON pr.TipUsluge=tu.TipUslugeID";

        public string UpdateQuery => throw new NotImplementedException();

        public string Aliaces => "";

        public string FilterQuery(string filter)
        {
            return $"lower(ime) like concat(lower('{filter}'),'%')" +
                $"or lower(prezime) like concat(lower('{filter}'),'%')" +
                $"or TipUsluge in (select TipUslugeID from TipUsluge where lower(NazivTipaUsluge) like concat(lower('{filter}'),'%'))";
        }

        public string FilterQueryStatus(StatusZahteva status)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(ReadFromReader(reader));
            }
            return list;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                return ReadFromReader(reader);
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        private IEntity ReadFromReader(SqlDataReader reader)
        {
            ProfilRadnika radnik = new ProfilRadnika();
            radnik.RadnikID = (int)reader["RadnikID"];
            radnik.Ime = (string)reader["Ime"];
            radnik.Prezime = (string)reader["Prezime"];
            radnik.Opis = (string)reader["Opis"];
            radnik.Fotografija = (byte[])reader["Fotografija"];
            radnik.TipUsluge = new TipUsluge
            {
                TipUslugeID = (int)reader["TipUslugeID"],
                NazivTipaUsluge = (string)reader["NazivTipaUsluge"]
            };
            return radnik;
        }
    }
}
