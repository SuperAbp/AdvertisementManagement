using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using SuperAbp.AdvertisementManagement.AdvertisementPositions;
using Lzez.Shop.AdvertisementManagement.AdvertisementPositions;
using System;

namespace SuperAbp.AdvertisementManagement.EntityFrameworkCore.AdvertisementPositions
{
    /// <summary>
    /// 广告位置
    /// </summary>
    public class AdvertisementPositionRepository : EfCoreRepository<AdvertisementManagementDbContext, AdvertisementPosition, Guid>, IAdvertisementPositionRepository
    {
        /// <summary>
        /// .ctor
        ///</summary>
        public AdvertisementPositionRepository(
            IDbContextProvider<AdvertisementManagementDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // TODO:编写仓储代码
    }
}