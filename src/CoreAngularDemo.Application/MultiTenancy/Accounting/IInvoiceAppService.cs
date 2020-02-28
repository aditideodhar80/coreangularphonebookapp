using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using CoreAngularDemo.MultiTenancy.Accounting.Dto;

namespace CoreAngularDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
