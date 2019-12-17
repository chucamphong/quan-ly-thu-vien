using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public sealed class PublisherService : Service<Publisher>, IPublisherService
    {
        protected override BaseData<Publisher> CreateInstance()
        {
            return new PublisherData();
        }
    }
}
