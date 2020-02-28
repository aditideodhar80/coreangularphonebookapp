using System.Collections.Generic;
using MvvmHelpers;
using CoreAngularDemo.Models.NavigationMenu;

namespace CoreAngularDemo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}