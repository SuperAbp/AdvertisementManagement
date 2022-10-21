using System;
using Volo.Abp.Application.Dtos;

namespace SuperAbp.AdvertisementManagement.Advertisements
{
    /// <summary>
    /// 查询条件
    /// </summary>
    public class GetAdvertisementsInput : PagedAndSortedResultRequestDto
    {
        public Guid? AdvertisementPositionId { get; set; }
    }
}