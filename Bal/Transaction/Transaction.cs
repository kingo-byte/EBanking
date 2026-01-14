using Common.Models;
using Dal.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bal.Services
{
    /// <summary>
    /// Business Access Layer for Transaction operations
    /// Responsibility: Business logic, validation, decision making
    /// NOT responsible for: Database access, HTTP handling
    /// </summary>
    public partial class Transaction
    {
        private readonly TransactionRepository _transactionRepository;

        public Transaction(TransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        /// <summary>
        /// Gets all transactions with business rules applied
        /// </summary>
        /// <returns>List of transactions</returns>
        public async Task<List<Common.Models.Transaction>> GetAllTransactionsAsync()
        {
            // Call the repository to get data
            var transactions = await _transactionRepository.GetAllTransactionsAsync();

            // Business rules can be applied here
            // For example:
            // - Filter out cancelled transactions
            // - Apply user permissions
            // - Calculate totals or summaries
            // For now, we just return the data

            return transactions;
        }
    }
}