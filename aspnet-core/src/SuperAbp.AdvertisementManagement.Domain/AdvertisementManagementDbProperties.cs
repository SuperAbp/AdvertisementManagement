namespace SuperAbp.AdvertisementManagement;

public static class AdvertisementManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "SuperAbp";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "AdvertisementManagement";
}