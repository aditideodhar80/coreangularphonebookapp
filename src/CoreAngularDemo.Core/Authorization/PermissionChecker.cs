using Abp.Authorization;
using CoreAngularDemo.Authorization.Roles;
using CoreAngularDemo.Authorization.Users;

namespace CoreAngularDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
