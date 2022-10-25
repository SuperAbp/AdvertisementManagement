using System;
using Volo.Abp.Application.Dtos;

namespace SuperAbp.AdvertisementManagement.Advertisements
{
    /// <summary>
    /// 查询条件
    /// </summary>
    public class GetAdvertisementsInput : PagedAndSortedResultRequestDto
    {
        /// <summary>
        /// 位置Id
        /// </summary>
        public Guid? AdvertisementPositionId { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        public bool? Enable { get; set; }
    }
}