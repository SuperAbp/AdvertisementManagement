using SuperAbp.AdvertisementManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SuperAbp.AdvertisementManagement.Permissions;

public class AdvertisementManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AdvertisementManagementPermissions.GroupName, L("Permission:AdvertisementManagement"));

        var advertisements = myGroup.AddPermission(AdvertisementManagementPermissions.Advertisements.Default, L("Permission:Advertisements"));
        advertisements.AddChild(AdvertisementManagementPermissions.Advertisements.Management, L("Permission:Management"));
        advertisements.AddChild(AdvertisementManagementPermissions.Advertisements.Create, L("Permission:Create"));
        advertisements.AddChild(AdvertisementManagementPermissions.Advertisements.Update, L("Permission:Edit"));
        advertisements.AddChild(AdvertisementManagementPermissions.Advertisements.Delete, L("Permission:Delete"));

        var advertisementPositions = myGroup.AddPermission(AdvertisementManagementPermissions.AdvertisementPositions.Default, L("Permission:AdvertisementPositions"));
        advertisementPositions.AddChild(AdvertisementManagementPermissions.AdvertisementPositions.Create, L("Permission:Create"));
        advertisementPositions.AddChild(AdvertisementManagementPermissions.AdvertisementPositions.Update, L("Permission:Edit"));
        advertisementPositions.AddChild(AdvertisementManagementPermissions.AdvertisementPositions.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AdvertisementManagementResource>(name);
    }
}