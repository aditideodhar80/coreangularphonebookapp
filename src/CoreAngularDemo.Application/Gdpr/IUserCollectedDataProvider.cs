using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using CoreAngularDemo.Dto;

namespace CoreAngularDemo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
