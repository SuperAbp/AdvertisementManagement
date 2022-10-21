using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace SuperAbp.AdvertisementManagement.EntityFrameworkCore;

[ConnectionStringName(AdvertisementManagementDbProperties.ConnectionStringName)]
public interface IAdvertisementManagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
