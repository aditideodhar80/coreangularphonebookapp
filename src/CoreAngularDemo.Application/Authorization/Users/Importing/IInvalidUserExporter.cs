using System.Collections.Generic;
using CoreAngularDemo.Authorization.Users.Importing.Dto;
using CoreAngularDemo.Dto;

namespace CoreAngularDemo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
