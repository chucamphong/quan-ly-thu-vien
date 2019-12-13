using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public sealed class PublisherData
    {
        private static readonly LibraryManagementSystemContext Context = new LibraryManagementSystemContext();

        public static int Count()
        {
            return Context.Books.Count();
        }
    }
}
