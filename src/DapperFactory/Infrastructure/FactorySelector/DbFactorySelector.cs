using DapperFactory.Application.Interfaces;
using DapperFactory.Domain.Entities.Enums;
using DapperFactory.Domain.Factory;
using System;

namespace DapperFactory.Infrastructure.FactorySelector
{
    public static class DbFactorySelector
    {
        public static IDapperFactory GetConnection(DBType dbType, string connectionString, string connectionName)
        {
            switch (dbType)
            {
                case DBType.Oracle:
                    return new OracleFactory(connectionString, dbType, connectionName);
                case DBType.SQLServer:
                    return new SQLServerFactory(connectionString, dbType, connectionName);
                case DBType.MySQL:
                    return new MySQLFactory(connectionString, dbType, connectionName);
                case DBType.PostgreSQL:
                    return new PostgreSQLFactory(connectionString, dbType, connectionName);
                case DBType.SQLite:
                    return new SQLiteFactory(connectionString, dbType, connectionName);
                default:
                    throw new ArgumentException("Unsupported db type");
            }
        }
    }
}
