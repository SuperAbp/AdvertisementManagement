using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace SuperAbp.AdvertisementManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(SuperAbpAdvertisementManagementDomainSharedModule)
)]
public class SuperAbpAdvertisementManagementDomainModule : AbpModule
{
}