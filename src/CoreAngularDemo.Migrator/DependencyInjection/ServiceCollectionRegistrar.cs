﻿using Abp.Dependency;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using CoreAngularDemo.Identity;

namespace CoreAngularDemo.Migrator.DependencyInjection
{
    public static class ServiceCollectionRegistrar
    {
        public static void Register(IIocManager iocManager)
        {
            var services = new ServiceCollection();

            IdentityRegistrar.Register(services);

            WindsorRegistrationHelper.CreateServiceProvider(iocManager.IocContainer, services);
        }
    }
}
