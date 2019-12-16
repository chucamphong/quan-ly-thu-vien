using DataAccessLayer.Data;

namespace BusinessLogicLayer
{
    public class PublisherLogic
    {
        public static int Count()
        {
            using (var publisherData = new PublisherData())
            {
                return publisherData.Count();
            }
        }
    }
}
