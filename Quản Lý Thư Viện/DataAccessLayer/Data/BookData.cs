using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataTransferObject;

namespace DataAccessLayer.Data
{
    public sealed class BookData : BaseData<Book>
    {
        public override Book Find(int id)
        {
            return this.Get(book => book.Id == id, includeProperties: "Publishers, Authors, Categories").FirstOrDefault();
        }
    }
}
