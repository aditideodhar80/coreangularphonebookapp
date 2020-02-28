using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreAngularDemo
{
    public class CoreAngularDemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreAngularDemoClientModule).GetAssembly());
        }
    }
}
