using System.Threading.Tasks;
using Abp.Application.Services;
using CoreAngularDemo.Configuration.Host.Dto;

namespace CoreAngularDemo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
