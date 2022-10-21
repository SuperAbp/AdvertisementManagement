using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Lzez.Shop.AdvertisementManagement.AdvertisementPositions
{
    /// <summary>
    /// 广告位置
    /// </summary>
    public class AdvertisementPosition : CreationAuditedEntity<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; }
    }
}