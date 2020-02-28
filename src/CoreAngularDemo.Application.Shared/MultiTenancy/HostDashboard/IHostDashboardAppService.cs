using System.Threading.Tasks;
using Abp.Application.Services;
using CoreAngularDemo.MultiTenancy.HostDashboard.Dto;

namespace CoreAngularDemo.MultiTenancy.HostDashboard
{
    public interface IHostDashboardAppService : IApplicationService
    {
        Task<HostDashboardData> GetDashboardStatisticsData(GetDashboardDataInput input);

        Task<GetIncomeStatisticsDataOutput> GetIncomeStatistics(GetIncomeStatisticsDataInput input);

        Task<GetEditionTenantStatisticsOutput> GetEditionTenantStatistics(GetEditionTenantStatisticsInput input);
    }
}