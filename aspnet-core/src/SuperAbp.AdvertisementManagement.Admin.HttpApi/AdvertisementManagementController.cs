using SuperAbp.AdvertisementManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SuperAbp.AdvertisementManagement;

public abstract class AdvertisementManagementController : AbpControllerBase
{
    protected AdvertisementManagementController()
    {
        LocalizationResource = typeof(AdvertisementManagementResource);
    }
}
