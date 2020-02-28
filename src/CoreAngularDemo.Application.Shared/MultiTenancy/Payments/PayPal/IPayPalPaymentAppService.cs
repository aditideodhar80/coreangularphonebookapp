using System.Threading.Tasks;
using Abp.Application.Services;
using CoreAngularDemo.MultiTenancy.Payments.Dto;
using CoreAngularDemo.MultiTenancy.Payments.PayPal.Dto;

namespace CoreAngularDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalPaymentId, string paypalPayerId);

        PayPalConfigurationDto GetConfiguration();

        Task CancelPayment(CancelPaymentDto input);
    }
}
