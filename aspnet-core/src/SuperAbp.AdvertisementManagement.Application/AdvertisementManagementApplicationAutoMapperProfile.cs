using SuperAbp.AdvertisementManagement.AdvertisementPositions;
using SuperAbp.AdvertisementManagement.Advertisements;
using AutoMapper;
using Lzez.Shop.AdvertisementManagement.Advertisements;
using Lzez.Shop.AdvertisementManagement.AdvertisementPositions;

namespace SuperAbp.AdvertisementManagement;

public class AdvertisementManagementApplicationAutoMapperProfile : Profile
{
    public AdvertisementManagementApplicationAutoMapperProfile()
    {
        #region 广告

        CreateMap<Advertisement, AdvertisementListDto>();

        #endregion 广告
    }
}