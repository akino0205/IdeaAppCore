using IdeaAppCore.Models;
using Microsoft.Extensions.Options;

namespace IdeaAppCore.Services
{
    public class AppSettingService
    {
        public AppSettings _appSettings { get; }

        public AppSettingService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public string GetUserManageAPIBaseAddress()
        {
            return _appSettings.UserManageAPIBaseAddress;
        }
    }
}
