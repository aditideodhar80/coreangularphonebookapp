using Abp.AspNetCore.Mvc.ViewComponents;

namespace CoreAngularDemo.Web.Public.Views
{
    public abstract class CoreAngularDemoViewComponent : AbpViewComponent
    {
        protected CoreAngularDemoViewComponent()
        {
            LocalizationSourceName = CoreAngularDemoConsts.LocalizationSourceName;
        }
    }
}