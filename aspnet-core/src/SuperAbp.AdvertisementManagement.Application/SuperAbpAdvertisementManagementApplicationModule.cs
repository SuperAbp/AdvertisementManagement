using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace SuperAbp.AdvertisementManagement;

[DependsOn(
    typeof(SuperAbpAdvertisementManagementDomainModule),
    typeof(SuperAbpAdvertisementManagementApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class SuperAbpAdvertisementManagementApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<SuperAbpAdvertisementManagementApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<SuperAbpAdvertisementManagementApplicationModule>(validate: true);
        });
    }
}