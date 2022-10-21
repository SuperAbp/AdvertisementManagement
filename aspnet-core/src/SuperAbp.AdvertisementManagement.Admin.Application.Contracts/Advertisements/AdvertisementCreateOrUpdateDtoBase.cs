namespace SuperAbp.AdvertisementManagement.Advertisements
{
    public class AdvertisementCreateOrUpdateDtoBase
    {
        public string Name { get; set; }

        public string Link { get; set; }
        public string Description { get; set; }
        public System.Guid MediaId { get; set; }
        public int Sort { get; set; }

        public bool Enable { get; set; }
        public System.Guid AdvertisementPositionId { get; set; }
    }
}