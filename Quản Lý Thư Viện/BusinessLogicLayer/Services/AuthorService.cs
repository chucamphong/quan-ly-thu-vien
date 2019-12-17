using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public sealed class AuthorService : Service<Author>, IAuthorService
    {
        public List<Author> FindByName(string name)
        {
            using (var authorData = this.CreateInstance())
            {
                return authorData.Get(author => author.Name.Contains(name))
                                 .ToList();
            }
        }

        protected override BaseData<Author> CreateInstance()
        {
            return new AuthorData();
        }
    }
}
