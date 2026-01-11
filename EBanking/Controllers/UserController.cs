using Bal.User;
using Microsoft.AspNetCore.Mvc;

namespace EBanking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserBal _userBal;

        public UserController(UserBal userBal)
        {
            _userBal = userBal;
        }

        [HttpGet(Name = "GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userBal.GetUsers());
        }
    }
}
