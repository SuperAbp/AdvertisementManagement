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
using Lzez.Shop.AdvertisementManagement.Advertisements;
using SuperAbp.AdvertisementManagement.AdvertisementPositions;

namespace SuperAbp.AdvertisementManagement.Advertisements
{
    /// <summary>
    /// 广告管理
    /// </summary>
    [Authorize(AdvertisementManagementPermissions.Advertisements.Default)]
    public class AdvertisementAppService : AdvertisementManagementAdminAppService, IAdvertisementAppService
    {
        private readonly IAdvertisementRepository _advertisementRepository;
        private readonly IAdvertisementPositionRepository _advertisementPositionRepository;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="advertisementRepository"></param>
        public AdvertisementAppService(
            IAdvertisementRepository advertisementRepository, IAdvertisementPositionRepository advertisementPositionRepository)
        {
            _advertisementRepository = advertisementRepository;
            _advertisementPositionRepository = advertisementPositionRepository;
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="input">查询条件</param>
        /// <returns>结果</returns>
        public virtual async Task<PagedResultDto<AdvertisementListDto>> GetListAsync(GetAdvertisementsInput input)
        {
            await NormalizeMaxResultCountAsync(input);

            var advertisementQueryable = await _advertisementRepository.GetQueryableAsync();
            advertisementQueryable = advertisementQueryable
                .WhereIf(input.AdvertisementPositionId.HasValue,
                    a => a.AdvertisementPositionId == input.AdvertisementPositionId.Value)
                .WhereIf(input.Enable.HasValue,
                    a => a.Enable == input.Enable.Value);
            var queryable = (from a in advertisementQueryable
                             join p in await _advertisementPositionRepository.GetQueryableAsync() on a.AdvertisementPositionId equals p.Id
                             select new AdvertisementWithPosition
                             {
                                 Id = a.Id,
                                 Link = a.Link,
                                 Name = a.Name,
                                 MediaId = a.MediaId,
                                 Enable = a.Enable,
                                 Sort = a.Sort,
                                 AdvertisementPosition = p.Name,
                                 CreationTime = a.CreationTime
                             });

            long totalCount = await AsyncExecuter.CountAsync(queryable);

            var entities = await AsyncExecuter.ToListAsync(queryable
                .OrderBy(input.Sorting ?? AdvertisementConsts.DefaultSorting)
                .PageBy(input));

            var dtos = ObjectMapper.Map<List<AdvertisementWithPosition>, List<AdvertisementListDto>>(entities);

            return new PagedResultDto<AdvertisementListDto>(totalCount, dtos);
        }

        /// <summary>
        /// 获取修改
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public virtual async Task<GetAdvertisementForEditorOutput> GetEditorAsync(Guid id)
        {
            Advertisement entity = await _advertisementRepository.GetAsync(id);

            return ObjectMapper.Map<Advertisement, GetAdvertisementForEditorOutput>(entity);
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Authorize(AdvertisementManagementPermissions.Advertisements.Create)]
        public virtual async Task CreateAsync(AdvertisementCreateDto input)
        {
            var entity = ObjectMapper.Map<AdvertisementCreateDto, Advertisement>(input);
            entity = await _advertisementRepository.InsertAsync(entity);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="input"></param>
        /// <returns></returns>
        [Authorize(AdvertisementManagementPermissions.Advertisements.Update)]
        public virtual async Task UpdateAsync(Guid id, AdvertisementUpdateDto input)
        {
            Advertisement entity = await _advertisementRepository.GetAsync(id);
            entity = ObjectMapper.Map(input, entity);
            entity = await _advertisementRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        [Authorize(AdvertisementManagementPermissions.Advertisements.Delete)]
        public virtual async Task DeleteAsync(Guid id)
        {
            await _advertisementRepository.DeleteAsync(s => s.Id == id);
        }

        /// <summary>
        /// 规范最大记录数
        /// </summary>
        /// <param name="input">参数</param>
        /// <returns></returns>
        private async Task NormalizeMaxResultCountAsync(PagedAndSortedResultRequestDto input)
        {
            var maxPageSize = (await SettingProvider.GetOrNullAsync(AdvertisementSettings.MaxPageSize))?.To<int>();
            if (maxPageSize.HasValue && input.MaxResultCount > maxPageSize.Value)
            {
                input.MaxResultCount = maxPageSize.Value;
            }
        }
    }
}