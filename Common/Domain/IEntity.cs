using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        string PrimaryKey {  get; }
        string GetById { get; }
        string JoinQuery { get; }
        string UpdateQuery { get; }
        string Aliaces { get; }

        string FilterQuery(string filter);
        string FilterQueryStatus(StatusZahteva status);
        List<IEntity> GetReaderList(SqlDataReader reader);
        IEntity GetReaderResult(SqlDataReader reader);

    }
}
