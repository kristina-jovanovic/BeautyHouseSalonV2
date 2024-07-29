using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        private DBConnection connection;
        public Broker()
        {
            connection = new DBConnection();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        ///
        public void Insert(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"insert into {entity.TableName} values ({entity.Values})";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            //Debug.WriteLine("--------INSERT USPESAN");
        }
        public void Update(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"update {entity.TableName} set {entity.UpdateQuery} where {entity.PrimaryKey}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public void Delete(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"delete from {entity.TableName} where {entity.PrimaryKey}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public IEntity GetEntityById(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select *{entity.Aliaces} from {entity.TableName} {entity.JoinQuery} where {entity.GetById}";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                entity = entity.GetReaderResult(reader);
            }
            cmd.Dispose();
            return entity;
        }

        public List<IEntity> GetEntitiesById(IEntity entity, StatusZahteva status)
        {
            List<IEntity> list = new List<IEntity>();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select *{entity.Aliaces} from {entity.TableName} {entity.JoinQuery} where {entity.FilterQueryStatus(status)}";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                list = entity.GetReaderList(reader);
            }
            cmd.Dispose();
            return list;
        }

        public List<IEntity> ReadAll(IEntity entity)
        {
            List<IEntity> list = new List<IEntity>();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select * from {entity.TableName} {entity.JoinQuery}";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                list = entity.GetReaderList(reader);
            }
            cmd.Dispose();
            return list;
        }

        public List<IEntity> ReadAllWithFilter(IEntity entity, string filter)
        {
            List<IEntity> list = new List<IEntity>();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select *{entity.Aliaces} from {entity.TableName} {entity.JoinQuery} where {entity.FilterQuery(filter)}";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                list = entity.GetReaderList(reader);
            }
            cmd.Dispose();
            return list;
        }

        
    }
}
