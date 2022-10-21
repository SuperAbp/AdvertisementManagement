using Volo.Abp.Modularity;

namespace SuperAbp.AdvertisementManagement;

[DependsOn(
    typeof(AdvertisementManagementApplicationModule),
    typeof(AdvertisementManagementDomainTestModule)
    )]
public class AdvertisementManagementApplicationTestModule : AbpModule
{

}
