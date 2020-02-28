using System.Collections.Generic;
using CoreAngularDemo.Authorization.Users.Dto;
using CoreAngularDemo.Dto;

namespace CoreAngularDemo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}