using Abp.AspNetCore.Mvc.Views;

namespace CoreAngularDemo.Web.Views
{
    public abstract class CoreAngularDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected CoreAngularDemoRazorPage()
        {
            LocalizationSourceName = CoreAngularDemoConsts.LocalizationSourceName;
        }
    }
}
