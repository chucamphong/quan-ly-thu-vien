using DataTransferObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public sealed class BookData
    {
        private static readonly LibraryManagementSystemContext Context = new LibraryManagementSystemContext();

        public static int CountAll()
        {
            return Context.Books.Count();
        }
    }
}
