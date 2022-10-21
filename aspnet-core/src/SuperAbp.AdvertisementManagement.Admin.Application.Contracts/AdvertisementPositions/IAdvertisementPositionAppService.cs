using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SuperAbp.AdvertisementManagement.AdvertisementPositions
{
    /// <summary>
    /// 广告位置管理
    /// </summary>
    public interface IAdvertisementPositionAppService : IApplicationService
    {
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="input">查询条件</param>
        /// <returns>结果</returns>
        Task<PagedResultDto<AdvertisementPositionListDto>> GetListAsync(GetAdvertisementPositionsInput input);

        /// <summary>
        /// 获取修改
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        Task<GetAdvertisementPositionForEditorOutput> GetEditorAsync(Guid id);

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<AdvertisementPositionListDto> CreateAsync(AdvertisementPositionCreateDto input);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<AdvertisementPositionListDto> UpdateAsync(Guid id, AdvertisementPositionUpdateDto input);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        Task DeleteAsync(Guid id);
    }
}