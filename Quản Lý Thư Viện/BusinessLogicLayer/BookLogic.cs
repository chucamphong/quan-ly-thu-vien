using DataAccessLayer.Data;

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
