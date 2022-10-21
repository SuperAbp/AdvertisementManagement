using SuperAbp.AdvertisementManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SuperAbp.AdvertisementManagement;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(AdvertisementManagementEntityFrameworkCoreTestModule)
    )]
public class AdvertisementManagementDomainTestModule : AbpModule
{

}
