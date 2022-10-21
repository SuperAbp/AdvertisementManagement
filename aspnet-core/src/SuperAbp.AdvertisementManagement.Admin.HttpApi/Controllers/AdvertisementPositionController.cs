using Microsoft.AspNetCore.Mvc;
using SuperAbp.AdvertisementManagement.AdvertisementPositions;
using SuperAbp.AdvertisementManagement.Advertisements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace SuperAbp.AdvertisementManagement.Controllers
{
    /// <summary>
    /// 广告
    /// </summary>
    [RemoteService(Name = AdvertisementManagementRemoteServiceConsts.RemoteServiceName)]
    [Area(AdvertisementManagementRemoteServiceConsts.ModuleName)]
    [Route("api/advertisement-management/advertisement-position")]
    public class AdvertisementPositionController : AdvertisementManagementController, IAdvertisementPositionAppService
    {
        private readonly IAdvertisementPositionAppService _advertisementPositionAppService;

        public AdvertisementPositionController(IAdvertisementPositionAppService advertisementPositionAppService)
        {
            _advertisementPositionAppService = advertisementPositionAppService;
        }

        /// <summary>
        /// 获取修改
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        [HttpGet("editor")]
        public async Task<GetAdvertisementPositionForEditorOutput> GetEditorAsync(Guid id)
        {
            return await _advertisementPositionAppService.GetEditorAsync(id);
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="input">查询条件</param>
        /// <returns>结果</returns>
        [HttpGet]
        public async Task<PagedResultDto<AdvertisementPositionListDto>> GetListAsync(GetAdvertisementPositionsInput input)
        {
            return await _advertisementPositionAppService.GetListAsync(input);
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<AdvertisementPositionListDto> CreateAsync(AdvertisementPositionCreateDto input)
        {
            return await _advertisementPositionAppService.CreateAsync(input);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<AdvertisementPositionListDto> UpdateAsync(Guid id, AdvertisementPositionUpdateDto input)
        {
            return await _advertisementPositionAppService.UpdateAsync(id, input);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await _advertisementPositionAppService.DeleteAsync(id);
        }
    }
}