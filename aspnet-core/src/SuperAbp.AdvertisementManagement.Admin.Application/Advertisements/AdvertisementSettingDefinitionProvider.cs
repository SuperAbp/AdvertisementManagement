using Volo.Abp.Settings;

namespace SuperAbp.AdvertisementManagement.Advertisements
{
    /// <summary>
    /// SettingDefinitionProvider
    /// </summary>
    public class AdvertisementSettingDefinitionProvider : SettingDefinitionProvider
    {
    /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Define(ISettingDefinitionContext context)
        {
            context.Add(
                new SettingDefinition(
                    AdvertisementSettings.MaxPageSize,
                    "100",
                    isVisibleToClients: true
                )
            );
        }
    }
}
