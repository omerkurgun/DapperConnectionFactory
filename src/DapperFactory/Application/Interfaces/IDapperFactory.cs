using DapperFactory.Domain.Entities.Enums;
using System.Data;

namespace DapperFactory.Application.Interfaces
{
    public interface IDapperFactory
    {
        DBType _dbType { get; }
        IDbConnection GetConnection();
        string _connName { get; }
    }
}
