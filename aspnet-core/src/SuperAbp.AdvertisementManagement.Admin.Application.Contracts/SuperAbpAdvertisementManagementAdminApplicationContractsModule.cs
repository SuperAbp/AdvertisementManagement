using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace SuperAbp.AdvertisementManagement;

[DependsOn(
    typeof(SuperAbpAdvertisementManagementApplicationContractsSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class SuperAbpAdvertisementManagementAdminApplicationContractsModule : AbpModule
{
}