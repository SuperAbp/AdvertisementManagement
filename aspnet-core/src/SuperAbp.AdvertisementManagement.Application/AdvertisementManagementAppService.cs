using SuperAbp.AdvertisementManagement.Localization;
using Volo.Abp.Application.Services;

namespace SuperAbp.AdvertisementManagement;

public abstract class AdvertisementManagementAppService : ApplicationService
{
    protected AdvertisementManagementAppService()
    {
        LocalizationResource = typeof(AdvertisementManagementResource);
        ObjectMapperContext = typeof(SuperAbpAdvertisementManagementApplicationModule);
    }
}