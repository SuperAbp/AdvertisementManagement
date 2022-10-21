using Localization.Resources.AbpUi;
using SuperAbp.AdvertisementManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace SuperAbp.AdvertisementManagement;

[DependsOn(
    typeof(SuperAbpAdvertisementManagementApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class SuperAbpAdvertisementManagementHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(SuperAbpAdvertisementManagementHttpApiModule).Assembly);
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