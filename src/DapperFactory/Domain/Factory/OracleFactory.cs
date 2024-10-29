using DapperFactory.Application.Interfaces;
using DapperFactory.Domain.Entities.Enums;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DapperFactory.Domain.Factory
{
    public class OracleFactory : IDapperFactory
    {
        public readonly string _connectionString;
        public DBType _dbType { get; }

        public string _connName { get; }

        public OracleFactory(string connectionString, DBType dbType, string connName)
        {
            _connectionString = connectionString;
            _dbType = dbType;
            _connName = connName;
        }

        public IDbConnection GetConnection()
        {
            return new OracleConnection(_connectionString);
        }
    }
}
