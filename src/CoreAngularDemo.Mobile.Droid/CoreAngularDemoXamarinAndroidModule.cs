using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreAngularDemo
{
    [DependsOn(typeof(CoreAngularDemoXamarinSharedModule))]
    public class CoreAngularDemoXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreAngularDemoXamarinAndroidModule).GetAssembly());
        }
    }
}