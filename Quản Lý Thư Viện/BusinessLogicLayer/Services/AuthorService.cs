using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public sealed class AuthorService : Service<Author>, IAuthorService
    {
        protected override BaseData<Author> CreateInstance()
        {
            return new AuthorData();
        }
    }
}
