using System.Threading.Tasks;
using Abp.Application.Services;
using CoreAngularDemo.Install.Dto;

namespace CoreAngularDemo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}