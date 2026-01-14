using Bal.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EBanking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly Transaction _transactionService;

        public TransactionController(Transaction transactionService)
        {
            _transactionService = transactionService;
        }

        /// <summary>
        /// Get all transactions
        /// </summary>
        /// <returns>List of all transactions</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllTransactions()
        {
            try
            {
                var transactions = await _transactionService.GetAllTransactionsAsync();
                return Ok(transactions);
            }
            catch (System.Exception ex)
            {
                // In production, log this error
                return StatusCode(500, new { message = "An error occurred", error = ex.Message });
            }
        }
    }
}