using Microsoft.Extensions.Configuration;

namespace CoreAngularDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
