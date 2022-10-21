using System;
using Volo.Abp.Application.Dtos;

namespace SuperAbp.AdvertisementManagement.AdvertisementPositions
{
    /// <summary>
    /// 列表
    /// </summary>
    public class AdvertisementPositionListDto : CreationAuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Enable { get; set; }
    }
}