using Common.Models;
using Dapper;
using Dal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dal.Repositories
{
    /// <summary>
    /// Data Access Layer for Transaction operations
    /// Responsibility: Execute stored procedures and return data
    /// NOT responsible for: Business rules, validation
    /// </summary>
    public class TransactionRepository
    {
        private readonly DapperAccess _dapperAccess;

        public TransactionRepository(DapperAccess dapperAccess)
        {
            _dapperAccess = dapperAccess;
        }

        /// <summary>
        /// Retrieves all transactions from the database
        /// </summary>
        /// <returns>List of all transactions</returns>
        public async Task<List<Transaction>> GetAllTransactionsAsync()
        {
            var parameters = new DynamicParameters();

            var transactions = await _dapperAccess.QueryAsync<Transaction>(
                storedProcedure: "sp_GetAllTransactions",
                parameters: parameters
            );

            return transactions;
        }
    }
}