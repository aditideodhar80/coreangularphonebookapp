using Abp.Events.Bus;

namespace CoreAngularDemo.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}