using System.Threading.Tasks;
using CoreAngularDemo.Sessions.Dto;

namespace CoreAngularDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
