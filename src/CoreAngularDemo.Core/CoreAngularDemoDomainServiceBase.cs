using Abp.Domain.Services;

namespace CoreAngularDemo
{
    public abstract class CoreAngularDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected CoreAngularDemoDomainServiceBase()
        {
            LocalizationSourceName = CoreAngularDemoConsts.LocalizationSourceName;
        }
    }
}
