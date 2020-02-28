using System.Linq;
using Abp.Configuration;
using Abp.Localization;
using Abp.MultiTenancy;
using Abp.Net.Mail;
using Microsoft.EntityFrameworkCore;
using CoreAngularDemo.EntityFrameworkCore;

namespace CoreAngularDemo.Migrations.Seed.Host
{
    public class DefaultSettingsCreator
    {
        private readonly CoreAngularDemoDbContext _context;

        public DefaultSettingsCreator(CoreAngularDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            int? tenantId = null;

            if (CoreAngularDemoConsts.MultiTenancyEnabled == false)
            {
                var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == MultiTenancy.Tenant.DefaultTenantName);
                tenantId = defaultTenant.Id;
            }

            //Emailing
            AddSettingIfNotExists(EmailSettingNames.DefaultFromAddress, "admin@mydomain.com", tenantId);
            AddSettingIfNotExists(EmailSettingNames.DefaultFromDisplayName, "mydomain.com mailer", tenantId);

            //Languages
            AddSettingIfNotExists(LocalizationSettingNames.DefaultLanguage, "en", tenantId);
        }

        private void AddSettingIfNotExists(string name, string value, int? tenantId = null)
        {
            if (_context.Settings.IgnoreQueryFilters().Any(s => s.Name == name && s.TenantId == tenantId && s.UserId == null))
            {
                return;
            }

            _context.Settings.Add(new Setting(tenantId, null, name, value));
            _context.SaveChanges();
        }
    }
}