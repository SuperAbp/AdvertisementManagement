using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SuperAbp.AdvertisementManagement.Advertisements
{
    /// <summary>
    /// 广告管理
    /// </summary>
    public interface IAdvertisementAppService : IApplicationService
    {
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="advertisementPositionCode">位置代码</param>
        /// <returns>结果</returns>
        Task<ListResultDto<AdvertisementListDto>> GetListAsync(string advertisementPositionCode);
    }
}