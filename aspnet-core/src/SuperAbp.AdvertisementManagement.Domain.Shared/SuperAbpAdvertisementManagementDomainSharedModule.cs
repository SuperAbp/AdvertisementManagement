using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using SuperAbp.AdvertisementManagement.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace SuperAbp.AdvertisementManagement;

[DependsOn(
    typeof(AbpValidationModule)
)]
public class SuperAbpAdvertisementManagementDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SuperAbpAdvertisementManagementDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AdvertisementManagementResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/AdvertisementManagement");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("AdvertisementManagement", typeof(AdvertisementManagementResource));
        });
    }
}