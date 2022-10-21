using SuperAbp.AdvertisementManagement.Samples;
using Xunit;

namespace SuperAbp.AdvertisementManagement.MongoDB.Samples;

[Collection(MongoTestCollection.Name)]
public class SampleRepository_Tests : SampleRepository_Tests<AdvertisementManagementMongoDbTestModule>
{
    /* Don't write custom repository tests here, instead write to
     * the base class.
     * One exception can be some specific tests related to MongoDB.
     */
}
