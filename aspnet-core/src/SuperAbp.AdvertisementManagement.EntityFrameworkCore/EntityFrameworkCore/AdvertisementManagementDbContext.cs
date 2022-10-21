using Lzez.Shop.AdvertisementManagement.AdvertisementPositions;
using Lzez.Shop.AdvertisementManagement.Advertisements;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace SuperAbp.AdvertisementManagement.EntityFrameworkCore;

[ConnectionStringName(AdvertisementManagementDbProperties.ConnectionStringName)]
public class AdvertisementManagementDbContext : AbpDbContext<AdvertisementManagementDbContext>, IAdvertisementManagementDbContext
{
    public DbSet<Advertisement> Advertisements { get; set; }
    public DbSet<AdvertisementPosition> AdvertisementPositions { get; set; }

    public AdvertisementManagementDbContext(DbContextOptions<AdvertisementManagementDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAdvertisementManagement();
    }
}