using Lzez.Shop.AdvertisementManagement.Advertisements;
using System;
using Volo.Abp.Domain.Repositories;

namespace SuperAbp.AdvertisementManagement.Advertisements
{
    /// <summary>
    /// 广告
    /// </summary>
    public interface IAdvertisementRepository : IRepository<Advertisement, Guid>
    {
    }
}