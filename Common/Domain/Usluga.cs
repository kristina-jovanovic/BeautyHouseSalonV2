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
        public TipUsluge TipUsluge { get; set; }

        public string TableName => "Usluga";

        public string Values => $"'{Naziv}', {Cena}, {TrajanjeUMinutima}, {TipUsluge.TipUslugeID}";

        public string PrimaryKey => $"UslugaID={UslugaID}";

        public string GetById => $"Naziv='{Naziv}' OR UslugaID={UslugaID}"; //PROMENJENO
        //public string GetById => $"Naziv='{Naziv}'"; 

        public string JoinQuery => "u JOIN TipUsluge tu ON u.TipUsluge=tu.TipUslugeID";

        public string UpdateQuery => $"Naziv='{Naziv}', Cena={Cena}, TrajanjeUMinutima={TrajanjeUMinutima}, TipUsluge={TipUsluge.TipUslugeID}";

        public string Aliaces => "";

        public override bool Equals(object obj)
        {
            return obj is Usluga usluga &&
                   UslugaID == usluga.UslugaID &&
                   Naziv == usluga.Naziv;
        }

        public string FilterQuery(string filter)
        {
            //return $"lower(naziv) like concat('%',lower('{filter}'),'%')" +
            //    $"or TipUsluge in (select TipUslugeID from TipUsluge where lower(NazivTipaUsluge) like concat('%',lower('{filter}'),'%'))";
            return $"lower(naziv) like concat('%',lower('{filter}'),'%')" +
                $"or TipUsluge in (select TipUslugeID from TipUsluge where lower(NazivTipaUsluge) like concat(lower('{filter}'),'%'))";
        }
        public string FilterQueryStatus(StatusZahteva status)
        {
            return null;
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

        public override string ToString()
        {
            return Naziv;
        }

        private IEntity ReadFromReader(SqlDataReader reader)
        {
            Usluga usluga = new Usluga();
            usluga.UslugaID = (int)reader["UslugaID"];
            usluga.Naziv = (string)reader["Naziv"];
            usluga.Cena = (double)reader["Cena"];
            usluga.TrajanjeUMinutima = (int)reader["TrajanjeUMinutima"];
            usluga.TipUsluge = new TipUsluge
            {
                TipUslugeID = (int)reader["TipUslugeID"],
                NazivTipaUsluge = (string)reader["NazivTipaUsluge"]
            };
            return usluga;
        }
    }
}
