using Volo.Abp.Reflection;

namespace SuperAbp.AdvertisementManagement.Permissions;

public class AdvertisementManagementPermissions
{
    public const string GroupName = "AdvertisementManagement";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AdvertisementManagementPermissions));
    }

    public static class Advertisements
    {
        public const string Default = GroupName + ".Advertisement";
        public const string Management = Default + ".Management";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }

    public static class AdvertisementPositions
    {
        public const string Default = GroupName + ".AdvertisementPosition";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }
}