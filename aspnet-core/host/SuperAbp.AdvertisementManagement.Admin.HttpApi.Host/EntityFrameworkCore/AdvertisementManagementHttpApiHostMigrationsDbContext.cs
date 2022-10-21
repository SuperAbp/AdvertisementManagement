using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SuperAbp.AdvertisementManagement.EntityFrameworkCore;

public class AdvertisementManagementHttpApiHostMigrationsDbContext : AbpDbContext<AdvertisementManagementHttpApiHostMigrationsDbContext>
{
    public AdvertisementManagementHttpApiHostMigrationsDbContext(DbContextOptions<AdvertisementManagementHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAdvertisementManagement();
    }
}
