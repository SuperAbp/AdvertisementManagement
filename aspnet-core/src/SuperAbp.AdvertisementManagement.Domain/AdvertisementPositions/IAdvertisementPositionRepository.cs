using Lzez.Shop.AdvertisementManagement.AdvertisementPositions;
using System;
using Volo.Abp.Domain.Repositories;

namespace SuperAbp.AdvertisementManagement.AdvertisementPositions
{
    /// <summary>
    /// 广告位置
    /// </summary>
    public interface IAdvertisementPositionRepository : IRepository<AdvertisementPosition, Guid>
    {
    }
}