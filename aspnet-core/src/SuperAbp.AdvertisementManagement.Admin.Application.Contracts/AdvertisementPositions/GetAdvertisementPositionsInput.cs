using Volo.Abp.Application.Dtos;

namespace SuperAbp.AdvertisementManagement.AdvertisementPositions
{
    /// <summary>
    /// 查询条件
    /// </summary>
    public class GetAdvertisementPositionsInput : PagedAndSortedResultRequestDto
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        public bool? Enable { get; set; }
    }
}