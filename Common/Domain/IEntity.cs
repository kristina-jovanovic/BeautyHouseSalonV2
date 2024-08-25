using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName();
        string Values();
        string PrimaryKey();
        string GetById();
        string JoinQuery();
        string UpdateQuery();
        string Aliaces();

        string FilterQuery(string filter);
        string FilterQueryStatus(StatusZahteva status);
        Task<List<IEntity>> GetReaderListAsync(SqlDataReader reader);
        Task<IEntity> GetReaderResultAsync(SqlDataReader reader);

    }
}
