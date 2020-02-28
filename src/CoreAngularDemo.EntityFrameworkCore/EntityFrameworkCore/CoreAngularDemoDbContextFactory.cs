using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CoreAngularDemo.Configuration;
using CoreAngularDemo.Web;

namespace CoreAngularDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CoreAngularDemoDbContextFactory : IDesignTimeDbContextFactory<CoreAngularDemoDbContext>
    {
        public CoreAngularDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CoreAngularDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            CoreAngularDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CoreAngularDemoConsts.ConnectionStringName));

            return new CoreAngularDemoDbContext(builder.Options);
        }
    }
}