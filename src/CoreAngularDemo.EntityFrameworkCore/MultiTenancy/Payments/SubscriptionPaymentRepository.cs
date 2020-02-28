using System.Linq;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using CoreAngularDemo.EntityFrameworkCore;
using CoreAngularDemo.EntityFrameworkCore.Repositories;

namespace CoreAngularDemo.MultiTenancy.Payments
{
    public class SubscriptionPaymentRepository : CoreAngularDemoRepositoryBase<SubscriptionPayment, long>, ISubscriptionPaymentRepository
    {
        public SubscriptionPaymentRepository(IDbContextProvider<CoreAngularDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<SubscriptionPayment> GetByGatewayAndPaymentIdAsync(SubscriptionPaymentGatewayType gateway, string paymentId)
        {
            return await SingleAsync(p => p.ExternalPaymentId == paymentId && p.Gateway == gateway);
        }

        public async Task<SubscriptionPayment> GetLastCompletedPaymentOrDefaultAsync(int tenantId, SubscriptionPaymentGatewayType? gateway, bool? isRecurring)
        {
            return await GetAll()
                .Where(p=> p.TenantId == tenantId)
                .Where(p => p.Status == SubscriptionPaymentStatus.Completed)
                .WhereIf(gateway.HasValue, p => p.Gateway == gateway.Value)
                .WhereIf(isRecurring.HasValue, p => p.IsRecurring == isRecurring.Value)
                .LastOrDefaultAsync();
        }

        public async Task<SubscriptionPayment> GetLastPaymentOrDefaultAsync(int tenantId, SubscriptionPaymentGatewayType? gateway, bool? isRecurring)
        {
            return await GetAll()
                .Where(p=> p.TenantId == tenantId)
                .WhereIf(gateway.HasValue, p => p.Gateway == gateway.Value)
                .WhereIf(isRecurring.HasValue, p => p.IsRecurring == isRecurring.Value)
                .LastOrDefaultAsync();
        }
    }
}
