using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BookLogic
    {
        public static int Count()
        {
            using (var bookData = new BookData())
            {
                return bookData.Count();
            }
        }
    }
}
