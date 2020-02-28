using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using CoreAngularDemo.Authorization.Users;
using CoreAngularDemo.MultiTenancy;

namespace CoreAngularDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}