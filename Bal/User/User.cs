using Common.Models;
using Common.Response;

namespace Bal.User
{
    public partial class UserBal
    {
        public async Task<GetUsersResponse> GetUsers()
        {
            GetUsersResponse response = new GetUsersResponse();

            List<Common.Models.User> users = await _dapperAccess.QueryAsync<Common.Models.User>("sp_GetUsers", null);

            response.Users = users;

            return response;
        }   
    }
}
