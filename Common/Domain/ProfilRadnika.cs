using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
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
        public string Fotografija { get; set; } //url fotografije
        public TipUsluge TipUsluge { get; set; }

        public string TableName => "ProfilRadnika";

        public string Values => $"'{Ime}', '{Prezime}', '{Opis}', '{Fotografija}', {TipUsluge.TipUslugeID}";

        public string PrimaryKey => RadnikID.ToString();

        //dodato or radnikid
        public string GetById => $"(Ime='{Ime}' and Prezime='{Prezime}') or RadnikID={RadnikID}";

        public string JoinQuery => "pr JOIN TipUsluge tu ON pr.TipUsluge=tu.TipUslugeID";

        public string UpdateQuery => null;

        public string Aliaces => "";

        public string FilterQuery(string filter)
        {
            return $"lower(ime) like concat(lower('{filter}'),'%')" +
                $"or lower(prezime) like concat(lower('{filter}'),'%')" +
                $"or TipUsluge in (select TipUslugeID from TipUsluge where lower(NazivTipaUsluge) like concat(lower('{filter}'),'%'))";
        }

        public string FilterQueryStatus(StatusZahteva status)
        {
            return null;
        }

        public async Task<List<IEntity>> GetReaderListAsync(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (await reader.ReadAsync())
            {
                list.Add(ReadFromReader(reader));
            }
            return list;
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
            radnik.Fotografija = (string)reader["Fotografija"];
            radnik.TipUsluge = new TipUsluge
            {
                TipUslugeID = (int)reader["TipUslugeID"],
                NazivTipaUsluge = (string)reader["NazivTipaUsluge"]
            };
            return radnik;
        }
    }
}
