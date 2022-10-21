using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace SuperAbp.AdvertisementManagement;

[DependsOn(
    typeof(SuperAbpAdvertisementManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule)
    )]
public class SuperAbpAdvertisementManagementApplicationContractsSharedModule : AbpModule
{
}