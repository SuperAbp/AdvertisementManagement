using System;
using System.Collections.Generic;
using System.Text;

namespace SuperAbp.AdvertisementManagement.Advertisements
{
    public class AdvertisementWithPosition
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Link { get; set; }

        public Guid MediaId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public string AdvertisementPosition { get; set; }

        public DateTime CreationTime { get; set; }
    }
}