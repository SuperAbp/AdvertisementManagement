using Lzez.Shop.AdvertisementManagement.AdvertisementPositions;
using Lzez.Shop.AdvertisementManagement.Advertisements;
using Microsoft.EntityFrameworkCore;
using SuperAbp.AdvertisementManagement.AdvertisementPositions;
using SuperAbp.AdvertisementManagement.Advertisements;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SuperAbp.AdvertisementManagement.EntityFrameworkCore;

public static class AdvertisementManagementDbContextModelCreatingExtensions
{
    public static void ConfigureAdvertisementManagement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Advertisement>(b =>
        {
            b.ToTable(AdvertisementManagementDbProperties.DbTablePrefix + "Advertisements", AdvertisementManagementDbProperties.DbSchema);

            b.ConfigureByConvention();
            b.ConfigureCreationAudited();

            b.Property(q => q.Name).HasMaxLength(AdvertisementConsts.MaxNameLength);
            b.Property(q => q.Link).HasMaxLength(AdvertisementConsts.MaxLinkLength);
            b.Property(q => q.Description).HasMaxLength(AdvertisementConsts.MaxDescriptionLength);
            b.Property(q => q.Sort).IsRequired().HasDefaultValue(0);
        });

        builder.Entity<AdvertisementPosition>(b =>
        {
            b.ToTable(AdvertisementManagementDbProperties.DbTablePrefix + "AdvertisementPositions", AdvertisementManagementDbProperties.DbSchema);

            b.ConfigureByConvention();
            b.ConfigureCreationAudited();

            b.Property(q => q.Name).HasMaxLength(AdvertisementPositionConsts.MaxNameLength);
            b.Property(q => q.Code).HasMaxLength(AdvertisementPositionConsts.MaxCodeLength);
        });
    }
}