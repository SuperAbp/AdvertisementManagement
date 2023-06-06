using System;
using Volo.Abp.Application.Dtos;

namespace SuperAbp.AdvertisementManagement.Advertisements
{
    /// <summary>
    /// 列表
    /// </summary>
    public class AdvertisementListDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public Guid MediaId { get; set; }
        public int Sort { get; set; }
    }
}