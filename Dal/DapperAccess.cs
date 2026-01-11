using Common;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace Dal
{
    public class DapperAccess
    {
        private readonly AppSettings _appSettings;

        public DapperAccess(IOptionsMonitor<AppSettings> appSettings)
        {
            _appSettings = appSettings.CurrentValue;
        }

        public async Task<List<T>> QueryAsync<T>(
           string storedProcedure,
           DynamicParameters? parameters)
        {
            using (IDbConnection db = new SqlConnection(_appSettings.ConnString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                    }

                    IEnumerable<T> result = await db.QueryAsync<T>(
                        storedProcedure,
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if (db.State == ConnectionState.Open)
                    {
                        db.Close();
                    }
                }
            }
        }
    }
}
