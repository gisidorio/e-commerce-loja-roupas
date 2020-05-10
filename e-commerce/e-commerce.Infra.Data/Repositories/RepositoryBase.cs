using Dapper;
using e_commerce.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public SqlConnection _conn;
        public string _connString = ConfigurationManager.ConnectionStrings["ecommerce"].ConnectionString;

        public RepositoryBase()
        {
            _conn = new SqlConnection(_connString);
        }

        public void ExecuteDelete(string procedure, object parameters = null)
        {
            _conn.Execute(procedure, parameters);
        }

        public T Query(string procedure, object parameters = null)
        {
            return _conn.Query<T>(procedure, parameters).ToList().FirstOrDefault();
        }

        public List<T> QueryList(string procedure, object parameters = null)
        {
            return _conn.Query<T>(procedure, parameters).ToList();
        }

        public void ExecuteSave(string procedure, object parameters = null)
        {
            _conn.Execute(procedure, parameters);
        }

        public void ExecuteUpdate(string procedure, object parameters = null)
        {
            _conn.Execute(procedure, parameters);
        }

        public void Dispose()
        {
            _conn.Close();
        }
    }
}
