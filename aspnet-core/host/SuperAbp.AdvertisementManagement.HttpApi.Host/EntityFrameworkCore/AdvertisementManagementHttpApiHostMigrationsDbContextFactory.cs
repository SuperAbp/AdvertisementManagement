using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SuperAbp.AdvertisementManagement.EntityFrameworkCore;

public class AdvertisementManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AdvertisementManagementHttpApiHostMigrationsDbContext>
{
    public AdvertisementManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AdvertisementManagementHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AdvertisementManagement"));

        return new AdvertisementManagementHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
