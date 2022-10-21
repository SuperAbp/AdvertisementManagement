using SuperAbp.AdvertisementManagement.AdvertisementPositions;
using SuperAbp.AdvertisementManagement.Advertisements;
using AutoMapper;
using Lzez.Shop.AdvertisementManagement.Advertisements;
using Lzez.Shop.AdvertisementManagement.AdvertisementPositions;

namespace SuperAbp.AdvertisementManagement;

public class AdvertisementManagementAdminApplicationAutoMapperProfile : Profile
{
    public AdvertisementManagementAdminApplicationAutoMapperProfile()
    {
        #region 广告

        CreateMap<Advertisement, GetAdvertisementForEditorOutput>();
        CreateMap<AdvertisementWithPosition, AdvertisementListDto>()
            .ForMember(entity => entity.CreatorId,
                    opt => opt.Ignore());
        CreateMap<Advertisement, AdvertisementDetailDto>();
        CreateMap<AdvertisementCreateDto, Advertisement>()
            .ForMember(entity => entity.CreationTime,
                    opt => opt.Ignore())
            .ForMember(entity => entity.CreatorId,
                    opt => opt.Ignore())
            .ForMember(entity => entity.Id,
                    opt => opt.Ignore());
        CreateMap<AdvertisementUpdateDto, Advertisement>()
            .ForMember(entity => entity.CreationTime,
                    opt => opt.Ignore())
            .ForMember(entity => entity.CreatorId,
                    opt => opt.Ignore())
            .ForMember(entity => entity.Id,
                    opt => opt.Ignore());

        #endregion 广告

        #region 广告位置

        CreateMap<AdvertisementPosition, GetAdvertisementPositionForEditorOutput>();
        CreateMap<AdvertisementPosition, AdvertisementPositionListDto>();
        CreateMap<AdvertisementPosition, AdvertisementPositionDetailDto>();
        CreateMap<AdvertisementPositionCreateDto, AdvertisementPosition>()
            .ForMember(entity => entity.CreationTime,
                    opt => opt.Ignore())
            .ForMember(entity => entity.CreatorId,
                    opt => opt.Ignore())
            .ForMember(entity => entity.Id,
                    opt => opt.Ignore());
        CreateMap<AdvertisementPositionUpdateDto, AdvertisementPosition>()
            .ForMember(entity => entity.CreationTime,
                    opt => opt.Ignore())
            .ForMember(entity => entity.CreatorId,
                    opt => opt.Ignore())
            .ForMember(entity => entity.Id,
                    opt => opt.Ignore());

        #endregion 广告位置
    }
}