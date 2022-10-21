using Localization.Resources.AbpUi;
using SuperAbp.AdvertisementManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace SuperAbp.AdvertisementManagement;

[DependsOn(
    typeof(SuperAbpAdvertisementManagementAdminApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class SuperAbpAdvertisementManagementAdminHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(SuperAbpAdvertisementManagementAdminHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AdvertisementManagementResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}