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
    public class AdvertisementAppService : AdvertisementManagementAppService, IAdvertisementAppService
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
        /// <param name="advertisementPositionCode">位置代码</param>
        /// <returns>结果</returns>
        public virtual async Task<ListResultDto<AdvertisementListDto>> GetListAsync(string advertisementPositionCode)
        {
            var queryable = from a in await _advertisementRepository.GetQueryableAsync()
                            join p in await _advertisementPositionRepository.GetQueryableAsync() on a.AdvertisementPositionId equals p.Id
                            where a.Enable && p.Enable && p.Code == advertisementPositionCode
                            select a;

            long totalCount = await AsyncExecuter.CountAsync(queryable);

            var entities = await AsyncExecuter.ToListAsync(queryable
                .OrderBy(AdvertisementConsts.DefaultSorting));

            var dtos = ObjectMapper.Map<List<Advertisement>, List<AdvertisementListDto>>(entities);

            return new PagedResultDto<AdvertisementListDto>(totalCount, dtos);
        }
    }
}