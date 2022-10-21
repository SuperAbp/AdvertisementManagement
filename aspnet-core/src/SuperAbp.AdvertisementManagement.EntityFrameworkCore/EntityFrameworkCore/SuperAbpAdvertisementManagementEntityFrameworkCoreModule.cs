using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SuperAbp.AdvertisementManagement.EntityFrameworkCore;

[DependsOn(
    typeof(SuperAbpAdvertisementManagementDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class SuperAbpAdvertisementManagementEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<AdvertisementManagementDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
        });
    }
}