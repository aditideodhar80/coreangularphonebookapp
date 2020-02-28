using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CoreAngularDemo.Authorization.Permissions.Dto;

namespace CoreAngularDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
