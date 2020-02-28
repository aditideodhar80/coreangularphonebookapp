using Abp.Application.Services;
using CoreAngularDemo.Dto;
using CoreAngularDemo.Logging.Dto;

namespace CoreAngularDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
