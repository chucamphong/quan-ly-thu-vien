using DataAccessLayer.Data;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLogicLayer
{
    public class AuthorLogic
    {
        public static List<Author> GetAll()
        {
            using (var authorData = new AuthorData())
            {
                return authorData.GetAll()
                                 .ToList();
            }
        }

        public static List<Author> FindByName(string name)
        {
            using (var authorData = new AuthorData())
            {
                return authorData.Get(author => author.Name.Contains(name))
                                 .ToList();
            }
        }

        public static int Count()
        {
            using (var authorData = new AuthorData())
            {
                return authorData.Count();
            }
        }

        public static void Update(Author author)
        {
            using (var authorData = new AuthorData())
            {
                authorData.Update(author);
                authorData.Save();
            }
        }

        public static void Delete(Author author)
        {
            using (var authorData = new AuthorData())
            {
                authorData.Delete(author);
                authorData.Save();
            }
        }
    }
}
