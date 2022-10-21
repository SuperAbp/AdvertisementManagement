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
    [Route("api/advertisement-management")]
    public class AdvertisementController : AdvertisementManagementController, IAdvertisementAppService
    {
        private readonly IAdvertisementAppService _advertisementAppService;

        public AdvertisementController(IAdvertisementAppService advertisementAppService)
        {
            _advertisementAppService = advertisementAppService;
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="advertisementPositionCode">位置代码</param>
        /// <returns>结果</returns>
        [HttpGet("{advertisementPositionCode}/advertisement")]
        public async Task<ListResultDto<AdvertisementListDto>> GetListAsync(string advertisementPositionCode)
        {
            return await _advertisementAppService.GetListAsync(advertisementPositionCode);
        }
    }
}