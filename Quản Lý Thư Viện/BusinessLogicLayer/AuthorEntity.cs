using DataAccessLayer.Data;

namespace BusinessLogicLayer
{
    public class AuthorEntity
    {
        public static int Count()
        {
            return AuthorData.Count();
        }
    }
}
