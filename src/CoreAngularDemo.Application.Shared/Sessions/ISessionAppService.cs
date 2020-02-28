using System.Threading.Tasks;
using Abp.Application.Services;
using CoreAngularDemo.Sessions.Dto;

namespace CoreAngularDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
