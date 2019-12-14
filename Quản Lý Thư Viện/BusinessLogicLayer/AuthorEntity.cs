using DataAccessLayer.Data;

namespace BusinessLogicLayer
{
    public class AuthorEntity
    {
        public static int Count()
        {
            using (var authorData = new AuthorData())
            {
                return authorData.Count();
            }
        }
    }
}
