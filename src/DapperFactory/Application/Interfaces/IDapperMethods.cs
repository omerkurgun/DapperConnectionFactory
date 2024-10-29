using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DapperFactory.Application.Interfaces
{
    public interface IDapperMethods
    {
        void SetConnection(IDbConnection dbConnection);

        #region Sync

        int Execute(string sql);

        int Execute(string sql, object param = null);

        object ExecuteScalar(string sql);

        object ExecuteScalar(string sql, object param = null);

        IEnumerable<T> Query<T>(string sql);

        IEnumerable<T> Query<T>(string sql, object param = null);

        T QueryFirst<T>(string sql);

        T QueryFirst<T>(string sql, object param = null);

        T QueryFirstOrDefault<T>(string sql);

        T QueryFirstOrDefault<T>(string sql, object param = null);

        T QuerySingle<T>(string sql);

        T QuerySingle<T>(string sql, object param = null);

        T QuerySingleOrDefault<T>(string sql);

        T QuerySingleOrDefault<T>(string sql, object param = null);

        #endregion

        #region Async

        Task<int> ExecuteAsync(string sql);

        Task<int> ExecuteAsync(string sql, object param = null);

        Task<object> ExecuteScalarAsync(string sql);

        Task<object> ExecuteScalarAsync(string sql, object param = null);

        Task<IEnumerable<T>> QueryAsync<T>(string sql);

        Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null);

        Task<T> QueryFirstAsync<T>(string sql);

        Task<T> QueryFirstAsync<T>(string sql, object param = null);

        Task<T> QueryFirstOrDefaultAsync<T>(string sql);

        Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null);

        Task<T> QuerySingleAsync<T>(string sql);

        Task<T> QuerySingleAsync<T>(string sql, object param = null);

        Task<T> QuerySingleOrDefaultAsync<T>(string sql);

        Task<T> QuerySingleOrDefaultAsync<T>(string sql, object param = null);

        #endregion
    }
}
