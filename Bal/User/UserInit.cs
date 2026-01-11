using Common;
using Dal;
using Microsoft.Extensions.Options;

namespace Bal.User
{
    public partial class UserBal
    {
        private readonly DapperAccess _dapperAccess;
        private readonly AppSettings _appSettings;

        public UserBal(
            DapperAccess dapperAccess,
            IOptionsMonitor<AppSettings> appSettings)
        {
            _dapperAccess = dapperAccess;
            _appSettings = appSettings.CurrentValue;
        }
    }
}
