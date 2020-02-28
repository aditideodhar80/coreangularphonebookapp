using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using CoreAngularDemo.Configure;
using CoreAngularDemo.Startup;
using CoreAngularDemo.Test.Base;

namespace CoreAngularDemo.GraphQL.Tests
{
    [DependsOn(
        typeof(CoreAngularDemoGraphQLModule),
        typeof(CoreAngularDemoTestBaseModule))]
    public class CoreAngularDemoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreAngularDemoGraphQLTestModule).GetAssembly());
        }
    }
}