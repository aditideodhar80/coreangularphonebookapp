using System.Threading.Tasks;
using Abp.Application.Services;
using CoreAngularDemo.Editions.Dto;
using CoreAngularDemo.MultiTenancy.Dto;

namespace CoreAngularDemo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}