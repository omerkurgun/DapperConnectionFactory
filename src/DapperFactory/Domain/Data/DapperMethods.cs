using Dapper;
using DapperFactory.Application.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DapperFactory.Domain.Data
{
    public class DapperMethods : IDapperMethods
    {
        private IDbConnection _dbConnection;

        public void SetConnection(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        #region Sync

        public int Execute(string sql)
        {
            return _dbConnection.Execute(sql);
        }

        public int Execute(string sql, object param = null)
        {
            return _dbConnection.Execute(sql, param);
        }

        public object ExecuteScalar(string sql)
        {
            return _dbConnection.ExecuteScalar(sql);
        }

        public object ExecuteScalar(string sql, object param = null)
        {
            return _dbConnection.ExecuteScalar(sql, param);
        }

        public IEnumerable<T> Query<T>(string sql)
        {
            return _dbConnection.Query<T>(sql);
        }

        public IEnumerable<T> Query<T>(string sql, object param = null)
        {
            return _dbConnection.Query<T>(sql, param);
        }

        public T QueryFirst<T>(string sql)
        {
            return _dbConnection.QueryFirst<T>(sql);
        }

        public T QueryFirst<T>(string sql, object param = null)
        {
            return _dbConnection.QueryFirst<T>(sql, param);
        }

        public T QueryFirstOrDefault<T>(string sql)
        {
            return _dbConnection.QueryFirstOrDefault<T>(sql);
        }

        public T QueryFirstOrDefault<T>(string sql, object param = null)
        {
            return _dbConnection.QueryFirstOrDefault<T>(sql, param);
        }

        public T QuerySingle<T>(string sql)
        {
            return _dbConnection.QuerySingle<T>(sql);
        }

        public T QuerySingle<T>(string sql, object param = null)
        {
            return _dbConnection.QuerySingle<T>(sql, param);
        }

        public T QuerySingleOrDefault<T>(string sql)
        {
            return _dbConnection.QuerySingleOrDefault<T>(sql);
        }

        public T QuerySingleOrDefault<T>(string sql, object param = null)
        {
            return _dbConnection.QuerySingleOrDefault<T>(sql, param);
        }

        #endregion

        #region Async

        public async Task<int> ExecuteAsync(string sql)
        {
            return await _dbConnection.ExecuteAsync(sql);
        }

        public async Task<int> ExecuteAsync(string sql, object param = null)
        {
            return await _dbConnection.ExecuteAsync(sql, param);
        }

        public async Task<object> ExecuteScalarAsync(string sql)
        {
            return await _dbConnection.ExecuteScalarAsync(sql);
        }

        public async Task<object> ExecuteScalarAsync(string sql, object param = null)
        {
            return await _dbConnection.ExecuteScalarAsync(sql, param);
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql)
        {
            return await _dbConnection.QueryAsync<T>(sql);
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null)
        {
            return await _dbConnection.QueryAsync<T>(sql, param);
        }

        public async Task<T> QueryFirstAsync<T>(string sql)
        {
            return await _dbConnection.QueryFirstAsync<T>(sql);
        }

        public async Task<T> QueryFirstAsync<T>(string sql, object param = null)
        {
            return await _dbConnection.QueryFirstAsync<T>(sql, param);
        }

        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql)
        {
            return await _dbConnection.QueryFirstOrDefaultAsync<T>(sql);
        }

        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null)
        {
            return await _dbConnection.QueryFirstOrDefaultAsync<T>(sql, param);
        }

        public async Task<T> QuerySingleAsync<T>(string sql)
        {
            return await _dbConnection.QuerySingleAsync<T>(sql);
        }

        public async Task<T> QuerySingleAsync<T>(string sql, object param = null)
        {
            return await _dbConnection.QuerySingleAsync<T>(sql, param);
        }

        public async Task<T> QuerySingleOrDefaultAsync<T>(string sql)
        {
            return await _dbConnection.QuerySingleOrDefaultAsync<T>(sql);
        }

        public async Task<T> QuerySingleOrDefaultAsync<T>(string sql, object param = null)
        {
            return await _dbConnection.QuerySingleOrDefaultAsync<T>(sql, param);
        }

        #endregion
    }
}
