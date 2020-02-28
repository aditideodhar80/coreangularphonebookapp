using System.Collections.Generic;
using CoreAngularDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace CoreAngularDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
