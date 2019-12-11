using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BookEntity
    {
        public static int Count()
        {
            return BookData.CountAll();
        }
    }
}
