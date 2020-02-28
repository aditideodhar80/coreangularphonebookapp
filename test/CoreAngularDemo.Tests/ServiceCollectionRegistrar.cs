//using Abp.Dependency;
//using Castle.MicroKernel.Registration;
//using Castle.Windsor.MsDependencyInjection;
//using Microsoft.Data.Sqlite;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using CoreAngularDemo.EntityFrameworkCore;
//using CoreAngularDemo.Identity;

//namespace CoreAngularDemo.Tests
//{
//    public static class ServiceCollectionRegistrar
//    {
//        public static void Register(IIocManager iocManager)
//        {
//            RegisterIdentity(iocManager);

//            var builder = new DbContextOptionsBuilder<CoreAngularDemoDbContext>();

//            var inMemorySqlite = new SqliteConnection("Data Source=:memory:");
//            builder.UseSqlite(inMemorySqlite);

//            iocManager.IocContainer.Register(
//                Component
//                    .For<DbContextOptions<CoreAngularDemoDbContext>>()
//                    .Instance(builder.Options)
//                    .LifestyleSingleton()
//            );

//            inMemorySqlite.Open();

//            new CoreAngularDemoDbContext(builder.Options).Database.EnsureCreated();
//        }

//        private static void RegisterIdentity(IIocManager iocManager)
//        {
//            var services = new ServiceCollection();

//            IdentityRegistrar.Register(services);

//            WindsorRegistrationHelper.CreateServiceProvider(iocManager.IocContainer, services);
//        }
//    }
//}
