using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using SuperAbp.AdvertisementManagement.Advertisements;
using System;
using Lzez.Shop.AdvertisementManagement.Advertisements;

namespace SuperAbp.AdvertisementManagement.EntityFrameworkCore.Advertisements
{
    /// <summary>
    /// 广告
    /// </summary>
    public class AdvertisementRepository : EfCoreRepository<AdvertisementManagementDbContext, Advertisement, Guid>, IAdvertisementRepository
    {
        /// <summary>
        /// .ctor
        ///</summary>
        public AdvertisementRepository(
            IDbContextProvider<AdvertisementManagementDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // TODO:编写仓储代码
    }
}