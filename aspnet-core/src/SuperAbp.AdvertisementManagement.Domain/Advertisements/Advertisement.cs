using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Lzez.Shop.AdvertisementManagement.Advertisements
{
    /// <summary>
    /// 广告
    /// </summary>
    public class Advertisement : CreationAuditedEntity<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        public Guid MediaId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; }

        public Guid AdvertisementPositionId { get; set; }
    }
}