using AbpMudBlazor.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpMudBlazor.Permissions;

public class AbpMudBlazorPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpMudBlazorPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpMudBlazorPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpMudBlazorResource>(name);
    }
}
