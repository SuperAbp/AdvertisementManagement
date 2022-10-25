using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp;
using Volo.Abp.Linq;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using SuperAbp.AdvertisementManagement.Permissions;
using Lzez.Shop.AdvertisementManagement.AdvertisementPositions;

namespace SuperAbp.AdvertisementManagement.AdvertisementPositions
{
    /// <summary>
    /// 广告位置管理
    /// </summary>
    [Authorize(AdvertisementManagementPermissions.AdvertisementPositions.Default)]
    public class AdvertisementPositionAppService : AdvertisementManagementAdminAppService, IAdvertisementPositionAppService
    {
        private readonly IAdvertisementPositionRepository _advertisementPositionRepository;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="advertisementPositionRepository"></param>
        public AdvertisementPositionAppService(
            IAdvertisementPositionRepository advertisementPositionRepository)
        {
            _advertisementPositionRepository = advertisementPositionRepository;
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="input">查询条件</param>
        /// <returns>结果</returns>
        public virtual async Task<PagedResultDto<AdvertisementPositionListDto>> GetListAsync(GetAdvertisementPositionsInput input)
        {
            await NormalizeMaxResultCountAsync(input);

            var queryable = await _advertisementPositionRepository.GetQueryableAsync();

            queryable = queryable
                .WhereIf(!input.Name.IsNullOrWhiteSpace(), p => p.Name.Contains(input.Name))
                .WhereIf(input.Enable.HasValue, p => p.Enable == input.Enable.Value);

            long totalCount = await AsyncExecuter.CountAsync(queryable);

            var entities = await AsyncExecuter.ToListAsync(queryable
                .OrderBy(input.Sorting ?? AdvertisementPositionConsts.DefaultSorting)
                .PageBy(input));

            var dtos = ObjectMapper.Map<List<AdvertisementPosition>, List<AdvertisementPositionListDto>>(entities);

            return new PagedResultDto<AdvertisementPositionListDto>(totalCount, dtos);
        }

        /// <summary>
        /// 获取修改
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public virtual async Task<GetAdvertisementPositionForEditorOutput> GetEditorAsync(Guid id)
        {
            AdvertisementPosition entity = await _advertisementPositionRepository.GetAsync(id);

            return ObjectMapper.Map<AdvertisementPosition, GetAdvertisementPositionForEditorOutput>(entity);
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Authorize(AdvertisementManagementPermissions.AdvertisementPositions.Create)]
        public virtual async Task<AdvertisementPositionListDto> CreateAsync(AdvertisementPositionCreateDto input)
        {
            var entity = ObjectMapper.Map<AdvertisementPositionCreateDto, AdvertisementPosition>(input);
            entity = await _advertisementPositionRepository.InsertAsync(entity, true);
            return ObjectMapper.Map<AdvertisementPosition, AdvertisementPositionListDto>(entity);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="input"></param>
        /// <returns></returns>
        [Authorize(AdvertisementManagementPermissions.AdvertisementPositions.Update)]
        public virtual async Task<AdvertisementPositionListDto> UpdateAsync(Guid id, AdvertisementPositionUpdateDto input)
        {
            AdvertisementPosition entity = await _advertisementPositionRepository.GetAsync(id);
            entity = ObjectMapper.Map(input, entity);
            entity = await _advertisementPositionRepository.UpdateAsync(entity);
            return ObjectMapper.Map<AdvertisementPosition, AdvertisementPositionListDto>(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        [Authorize(AdvertisementManagementPermissions.AdvertisementPositions.Delete)]
        public virtual async Task DeleteAsync(Guid id)
        {
            await _advertisementPositionRepository.DeleteAsync(s => s.Id == id);
        }

        /// <summary>
        /// 规范最大记录数
        /// </summary>
        /// <param name="input">参数</param>
        /// <returns></returns>
        private async Task NormalizeMaxResultCountAsync(PagedAndSortedResultRequestDto input)
        {
            var maxPageSize = (await SettingProvider.GetOrNullAsync(AdvertisementPositionSettings.MaxPageSize))?.To<int>();
            if (maxPageSize.HasValue && input.MaxResultCount > maxPageSize.Value)
            {
                input.MaxResultCount = maxPageSize.Value;
            }
        }
    }
}