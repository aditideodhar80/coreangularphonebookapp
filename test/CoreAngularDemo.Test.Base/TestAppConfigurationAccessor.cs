using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using CoreAngularDemo.Configuration;

namespace CoreAngularDemo.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(CoreAngularDemoTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
