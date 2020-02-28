using Abp.Auditing;
using CoreAngularDemo.Configuration.Dto;

namespace CoreAngularDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}