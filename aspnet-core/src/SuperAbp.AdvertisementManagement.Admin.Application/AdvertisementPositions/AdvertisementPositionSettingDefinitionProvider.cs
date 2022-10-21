using Volo.Abp.Settings;

namespace SuperAbp.AdvertisementManagement.AdvertisementPositions
{
    /// <summary>
    /// SettingDefinitionProvider
    /// </summary>
    public class AdvertisementPositionSettingDefinitionProvider : SettingDefinitionProvider
    {
    /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Define(ISettingDefinitionContext context)
        {
            context.Add(
                new SettingDefinition(
                    AdvertisementPositionSettings.MaxPageSize,
                    "100",
                    isVisibleToClients: true
                )
            );
        }
    }
}
