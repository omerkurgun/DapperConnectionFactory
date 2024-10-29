using DapperFactory.Application.Interfaces;
using DapperFactory.Domain.Entities.Enums;
using MySql.Data.MySqlClient;
using System.Data;

namespace DapperFactory.Domain.Factory
{
    public class MySQLFactory : IDapperFactory
    {
        public readonly string _connectionString;
        public DBType _dbType { get; }

        public string _connName { get; }

        public MySQLFactory(string connectionString, DBType dbType, string connName)
        {
            _connectionString = connectionString;
            _dbType = dbType;
            _connName = connName;
        }

        public IDbConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
