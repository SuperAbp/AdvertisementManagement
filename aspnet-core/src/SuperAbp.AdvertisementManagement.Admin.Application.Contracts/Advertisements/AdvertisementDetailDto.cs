using System;
using Volo.Abp.Application.Dtos;

namespace SuperAbp.AdvertisementManagement.Advertisements
{
    /// <summary>
    /// 列表
    /// </summary>
    public class AdvertisementDetailDto: EntityDto<Guid>
    {
        public string Link { get; set; }
        public System.Guid MediaId { get; set; }
        public int Sort { get; set; }
    }
}