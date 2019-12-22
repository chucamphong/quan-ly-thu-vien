using System.Collections.Generic;
using DataTransferObject;

namespace DataAccessLayer.Data
{
    public sealed class BookData : BaseData<Book>
    {
        public override IEnumerable<Book> All()
        {
            return this.Get(includeProperties: "Publishers, Authors, Categories");
        }
    }
}
