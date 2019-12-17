using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public sealed class BookService : Service<Book>, IBookService
    {
        protected override BaseData<Book> CreateInstance()
        {
            return new BookData();
        }
    }
}
