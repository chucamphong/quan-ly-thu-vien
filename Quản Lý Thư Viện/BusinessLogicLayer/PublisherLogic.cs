using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
