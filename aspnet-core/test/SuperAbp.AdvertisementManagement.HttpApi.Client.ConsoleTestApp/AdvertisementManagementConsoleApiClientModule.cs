using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SuperAbp.AdvertisementManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdvertisementManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AdvertisementManagementConsoleApiClientModule : AbpModule
{

}
