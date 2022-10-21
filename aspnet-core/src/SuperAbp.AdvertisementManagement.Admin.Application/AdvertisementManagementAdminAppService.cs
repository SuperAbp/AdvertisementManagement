using SuperAbp.AdvertisementManagement.Localization;
using Volo.Abp.Application.Services;

namespace SuperAbp.AdvertisementManagement;

public abstract class AdvertisementManagementAdminAppService : ApplicationService
{
    protected AdvertisementManagementAdminAppService()
    {
        LocalizationResource = typeof(AdvertisementManagementResource);
        ObjectMapperContext = typeof(SuperAbpAdvertisementManagementAdminApplicationModule);
    }
}