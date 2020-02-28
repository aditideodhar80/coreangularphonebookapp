using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CoreAngularDemo.EntityFrameworkCore
{
    public static class CoreAngularDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CoreAngularDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CoreAngularDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}