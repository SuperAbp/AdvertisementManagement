using Microsoft.AspNetCore.Mvc;
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
    [Route("api/advertisement-management/advertisement")]
    public class AdvertisementController : AdvertisementManagementController, IAdvertisementAppService
    {
        private readonly IAdvertisementAppService _advertisementAppService;

        public AdvertisementController(IAdvertisementAppService advertisementAppService)
        {
            _advertisementAppService = advertisementAppService;
        }

        /// <summary>
        /// 获取修改
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        [HttpGet("editor")]
        public async Task<GetAdvertisementForEditorOutput> GetEditorAsync(Guid id)
        {
            return await _advertisementAppService.GetEditorAsync(id);
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="input">查询条件</param>
        /// <returns>结果</returns>
        [HttpGet]
        public async Task<PagedResultDto<AdvertisementListDto>> GetListAsync(GetAdvertisementsInput input)
        {
            return await _advertisementAppService.GetListAsync(input);
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> CreateAsync(AdvertisementCreateDto input)
        {
            return await _advertisementAppService.CreateAsync(input);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task UpdateAsync(Guid id, AdvertisementUpdateDto input)
        {
            await _advertisementAppService.UpdateAsync(id, input);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await _advertisementAppService.DeleteAsync(id);
        }
    }
}