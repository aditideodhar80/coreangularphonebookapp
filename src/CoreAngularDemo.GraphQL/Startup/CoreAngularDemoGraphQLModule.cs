using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreAngularDemo.Startup
{
    [DependsOn(typeof(CoreAngularDemoCoreModule))]
    public class CoreAngularDemoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreAngularDemoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}