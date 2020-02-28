using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreAngularDemo
{
    [DependsOn(typeof(CoreAngularDemoXamarinSharedModule))]
    public class CoreAngularDemoXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreAngularDemoXamarinIosModule).GetAssembly());
        }
    }
}