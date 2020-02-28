using System.Threading.Tasks;
using Abp.Dependency;

namespace CoreAngularDemo.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}