using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreAngularDemo
{
    [DependsOn(typeof(CoreAngularDemoClientModule), typeof(AbpAutoMapperModule))]
    public class CoreAngularDemoXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreAngularDemoXamarinSharedModule).GetAssembly());
        }
    }
}